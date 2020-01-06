using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace _009일차_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        byte[,] inImage, outImage;
        int inH, inW, outH, outW;      
        string fileName = "";

        Bitmap paper;

        //*********************************
        // 공통 함수 모음
        //*********************************

        private void OpenImage()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "raw";
            ofd.Filter = "로우 File(*.raw) | *.raw";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                // 우선 파일의 크기를 파악해서 행과 열을 알아내기(중요!)
                long fSize = new FileInfo(fileName).Length;
                inH = inW = (int)Math.Sqrt(fSize);
                inImage = new byte[inH, inW];

                // 파일 --> 메모리 (Loading)
                BinaryReader br = new BinaryReader(File.Open(fileName, FileMode.Open));
                for (int i = 0; i < inH; i++)
                    for (int k = 0; k < inW; k++)
                        inImage[i, k] = br.ReadByte();

                br.Close();
                Equal();
            }

        }


        private void DisplayImage()
        {
            paper = new Bitmap(outH, outW);
            this.Size = new Size(outW + 30, outH + 90);
            pb_photo.Size = new Size(outH, outW);

            Color pen;
            int r, g, b;
            for (int i = 0; i < outH; i++)
                for (int k = 0; k < outW; k++)
                {
                    r = g = b = outImage[i, k];
                    pen = Color.FromArgb(r, g, b);
                    paper.SetPixel(k, i, pen);
                }
            pb_photo.Image = paper;
            tool_size.Text = "해상도:" + outH + "x" + outW;

        }

        private void SaveImage()  //저장
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "raw";
            sfd.Filter = "로우 이미지(*.raw) | *.raw";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string saveFname = sfd.FileName;
                BinaryWriter bw = new BinaryWriter(File.Open(saveFname, FileMode.Create));
                for (int i = 0; i < outH; i++)
                    for (int k = 0; k < outW; k++)
                        bw.Write(outImage[i, k]);
                bw.Close();
                tool_size.Text = saveFname + "이 저장됨";
            }
        }


        //*********************************
        // 영상처리 함수 모음
        //*********************************
        private void Equal()  // 동일영상 알고리즘
        {
            if (fileName.Length <= 0)
                return;
            // (중요!) 출력 영상의 크기를 결정
            outH = inH; outW = inW;
            outImage = new byte[outH, outW];
            /////////////////////////////
            // 진짜 영상처리 알고리즘 구현
            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                {
                    outImage[i, k] = inImage[i, k];  // Out <-- In
                }
            //////////////////////////////
            DisplayImage();
        }


        private void AddImage()  // 더하기 알고리즘
        {
            if (fileName.Length <= 0)
                return;
            // (중요!) 출력 영상의 크기를 결정
            outH = inH; outW = inW;
            outImage = new byte[outH, outW];
            /////////////////////////////
            // 진짜 영상처리 알고리즘 구현
            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                {
                    if (inImage[i, k] + 100 > 255)
                        outImage[i, k] = 255;
                    else
                        outImage[i, k] = (byte)(inImage[i, k] + 100);
                }
            //////////////////////////////
            DisplayImage();
        }

        private void BlackWhite127()  // 흑백 알고리즘 (127기준)
        {
            if (fileName.Length <= 0)
                return;
            // (중요!) 출력 영상의 크기를 결정
            outH = inH; outW = inW;
            outImage = new byte[outH, outW];
            /////////////////////////////
            // 진짜 영상처리 알고리즘 구현
            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                {
                    if (inImage[i, k] > 127)
                        outImage[i, k] = 255;
                    else
                        outImage[i, k] = 0;
                }
            //////////////////////////////
            DisplayImage();
        }

        private void BlackWhiteCenter()  // 흑백 알고리즘 (중위수 기준)
        {
            if (fileName.Length <= 0)
                return;
            // (중요!) 출력 영상의 크기를 결정
            outH = inH; outW = inW;
            outImage = new byte[outH, outW];
            /////////////////////////////
            // 진짜 영상처리 알고리즘 구현
            // 2차원 --> 1차원
            byte[] oneAry = new byte[inH * inW];
            long idx = 0;
            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                    oneAry[idx++] = inImage[i, k];
            Array.Sort(oneAry);
            Array.Reverse(oneAry);
            byte center = oneAry[(inH * inW) / 2];

            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                {
                    if (inImage[i, k] > center)
                        outImage[i, k] = 255;
                    else
                        outImage[i, k] = 0;
                }
            //////////////////////////////
            DisplayImage();
        }


        private void BlackWhiteMean()  // 흑백 알고리즘 (평균값 기준)
        {
            if (fileName.Length <= 0)
                return;
            // (중요!) 출력 영상의 크기를 결정
            outH = inH; outW = inW;
            outImage = new byte[outH, outW];
            /////////////////////////////
            // 진짜 영상처리 알고리즘 구현
            long hap = 0;
            double avg;
            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                    hap += inImage[i, k];
            avg = (double)hap / (inH * inW);

            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                {
                    if (inImage[i, k] > avg)
                        outImage[i, k] = 255;
                    else
                        outImage[i, k] = 0;
                }
            //////////////////////////////
            DisplayImage();
        }


        private void HistoEqual()  // 평활화 알고리즘
        {
            if (fileName.Length <= 0)
                return;
            // (중요!) 출력 영상의 크기를 결정
            outH = inH; outW = inW;
            outImage = new byte[outH, outW];
            /////////////////////////////
            // 진짜 영상처리 알고리즘 구현

            //** 1단계 : 히스토그램 생성

            long[] histo = new long[256];
            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                {
                    histo[inImage[i, k]]++;
                }


                    for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                {
                    outImage[i, k] = inImage[i, k];  // Out <-- In
                }
            //////////////////////////////
             DisplayImage();

            //** 2단계 : 누적히스토그램 생성

            long[] sumHisto = new long[256];
            //sumHisto[0] = histo[0];
            long sumValue = 0;
            for (int i = 0; i < 256; i++)
            {
                sumValue += histo[i];
                sumHisto[i] = sumValue;
            }
            //  sumHisto[i] = histo[i] + sumHisto[i - 1];  //앞에꺼 빼기

            // ** 3단계 : 정규화된 누적 히스토그램 생성
            // 결과 = (누적합 / (행*열)) *255.0
            double[] normalHisto = new double[256];
            for (int i = 0; i < 256; i++)
                normalHisto[i] = (sumHisto[i] / (inH * inW)) * 255.0;


            //** 4단계 : 입력 ---> 정규화된 값으로 변경
            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                {
                    outImage[i, k] = (byte)normalHisto[inImage[i, k]];
                }
        }

        private void Emboss()  // 엠보싱 알고리즘
        {
            if (fileName.Length <= 0)
                return;
            // (중요!) 출력 영상의 크기를 결정
            outH = inH; outW = inW;
            outImage = new byte[outH, outW];
            /////////////////////////////
            // 진짜 영상처리 알고리즘 구현
            const int mSize = 3;  //마스크 사이즈
            ///마스크를 정의 ---> 알고리즘 (수식)
            double[,] mask = new double[mSize, mSize]
            {
                { -1.0  ,  0.0  , 0.0 },
                { 0.0  ,  0.0 ,  0.0 },
                { 0.0  , 0.0 ,  1.0 },
            };

            //임시 입출력 배열 준비

            double[,] tmpInImage = new double[inH + 2, inW + 2];
            double[,] tmpOutImage = new double[inH + 2, inW ];

            //임시 입력 배열을 127정도로 초기화
            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                    tmpInImage[i, k] = 127.0;

            //입력영상 ---> 임시 입력
            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                    tmpInImage[i + 1, k + 1] = inImage[i, k];


            //회선 연산 처리    ----> 다 곱한값
            double S = 0.0;
            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                {
                    // 한점에 대해서 마스크와 연산
                    for (int m = 0; m < mSize; m++)
                        for (int n = 0; n < mSize; n++)
                            S += mask[m, n] * tmpInImage[m+i, n+k];
                    tmpOutImage[i,k] = S;
                    S = 0.0;
                }
            // 마스크에 따라서 후처리    >>> 마스크의 합계가 0이면 중간 합이 127  out 에다가
            for (int i = 0; i < outH; i++)
                for (int k = 0; k < outW; k++)
                    tmpOutImage[i, k] += 127.0;




            //임시 출력 --> 출력영상
             for (int i = 0; i < outH; i++)
                for (int k = 0; k < outW; k++)
                {
                    if (tmpOutImage[i, k] > 255)
                        outImage[i, k] = 255;
                    else if (tmpOutImage[i, k] < 0)
                        outImage[i, k] = 0;
                    else
                    outImage[i, k] = (byte)tmpOutImage[i, k];  // Out <-- In
                }
                    




            //////////////////////////////
            DisplayImage();
        }

        private void Blurr()  // 블러링 알고리즘
        {
            if (fileName.Length <= 0)
                return;
            // (중요!) 출력 영상의 크기를 결정
            outH = inH; outW = inW;
            outImage = new byte[outH, outW];
            /////////////////////////////
            // 진짜 영상처리 알고리즘 구현
            const int mSize = 3;  //마스크 사이즈
            ///마스크를 정의 ---> 알고리즘 (수식)
            double[,] mask = new double[mSize, mSize]
            {
                { 1/9.0  ,  1/9.0 ,1/9.0 },
            { 1 / 9.0  ,  1 / 9.0 ,  1 / 9.0 },
            { 1 / 9.0  , 1 / 9.0 ,  1 / 9.0 },
             };

            //임시 입출력 배열 준비

            double[,] tmpInImage = new double[inH + 2, inW + 2];
            double[,] tmpOutImage = new double[inH + 2, inW];

            //임시 입력 배열을 127정도로 초기화
            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                    tmpInImage[i, k] = 127.0;

            //입력영상 ---> 임시 입력
            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                    tmpInImage[i + 1, k + 1] = inImage[i, k];


            //회선 연산 처리    ----> 다 곱한값
            double S = 0.0;
            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                {
                    // 한점에 대해서 마스크와 연산
                    for (int m = 0; m < mSize; m++)
                        for (int n = 0; n < mSize; n++)
                            S += mask[m, n] * tmpInImage[m + i, n + k];
                    tmpOutImage[i, k] = S;
                    S = 0.0;
                }
 
            // 마스크에 따라서 후처리    >>> 마스크의 합계가 0이면 중간 합이 127  out 에다가
            //for (int i = 0; i < outH; i++)
            //    for (int k = 0; k < outW; k++)
            //        tmpOutImage[i, k] += 127.0;


            //임시 출력 --> 출력영상
            for (int i = 0; i < outH; i++)
                for (int k = 0; k < outW; k++)
                {
                    if (tmpOutImage[i, k] > 255)
                        outImage[i, k] = 255;
                    else if (tmpOutImage[i, k] < 0)
                        outImage[i, k] = 0;
                    else
                        outImage[i, k] = (byte)tmpOutImage[i, k];  // Out <-- In
                }





            //////////////////////////////
            DisplayImage();
        }
        private void Mophol()  // 모폴로지 알고리즘
        {
            if (fileName.Length <= 0)
                return;
            // (중요!) 출력 영상의 크기를 결정
            outH = inH; outW = inW;
            outImage = new byte[outH, outW];
            /////////////////////////////
            // 진짜 영상처리 알고리즘 구현
            
            const int mSize = 3;  //마스크 사이즈

            ///마스크를 정의 ---> 알고리즘 (수식)
            double[,] mask = new double[mSize, mSize]
            {
                { 1/9.0  ,  1/9.0 ,1/9.0 },
            { 1 / 9.0  ,  1 / 9.0 ,  1 / 9.0 },
            { 1 / 9.0  , 1 / 9.0 ,  1 / 9.0 },
             };


            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                {
                    outImage[i, k] = inImage[i, k];  // Out <-- In
                }
            //////////////////////////////
            DisplayImage();
        }


        private void Paracap()  // 파라볼라 캡 알고리즘
        {
            if (fileName.Length <= 0)
                return;
            // (중요!) 출력 영상의 크기를 결정
            outH = inH; outW = inW;
            outImage = new byte[outH, outW];
            /////////////////////////////
            // 진짜 영상처리 알고리즘 구현

            int[] LUT = new int[256];
            for (int i = 0; i < 256; i++)
            {
                LUT[i] = (int)(255.0 - 255.0 * Math.Pow(i / 128.0 - 1.0, 2));
                if (LUT[i] > 255)
                    LUT[i] = 255;
                else if (LUT[i] < 0)
                    LUT[i] = 0;
            }

            for (int i = 0; i < inH; i++)
                for (int k = 0; k < inW; k++)
                {
                    outImage[i, k] = (byte)LUT[inImage[i, k]];
                }
            //////////////////////////////
            DisplayImage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void 동일이미지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Equal();
        }

       

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void 밝게하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddImage();
        }

        private void 기준127ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlackWhite127();
        }

        private void 중위수ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlackWhiteCenter();
        }

        private void 평균값ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlackWhiteMean();
        }

      

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

       
        private void 히스토그램평활화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoEqual();
        }

        private void 엠보싱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emboss();
        }
        private void 블러링ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blurr();
        }
        private void 모폴로ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mophol();
        }

        private void paraCabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paracap();
        }

    }
}
