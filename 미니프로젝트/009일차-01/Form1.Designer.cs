namespace _009일차_01
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.히스토그램ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.히스토그램스트레칭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.앤드인탐색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.히스토그램평활화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.영상처리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.동일이미지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.밝게하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.흑백ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기준127ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.중위수ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.평균값ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.화면ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확대ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.축소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.좌우미러링ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상하미러링ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.반전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.화면확대역방향ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.감마변환ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파라볼라ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraCabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.화소영역ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.엠보싱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.블러링ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모폴로ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tool_size = new System.Windows.Forms.ToolStripStatusLabel();
            this.pb_photo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.히스토그램ToolStripMenuItem,
            this.영상처리ToolStripMenuItem,
            this.화소영역ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.저장ToolStripMenuItem.Text = "저장";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            // 
            // 히스토그램ToolStripMenuItem
            // 
            this.히스토그램ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.히스토그램스트레칭ToolStripMenuItem,
            this.앤드인탐색ToolStripMenuItem,
            this.히스토그램평활화ToolStripMenuItem});
            this.히스토그램ToolStripMenuItem.Name = "히스토그램ToolStripMenuItem";
            this.히스토그램ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.히스토그램ToolStripMenuItem.Text = "히스토그램";
            // 
            // 히스토그램스트레칭ToolStripMenuItem
            // 
            this.히스토그램스트레칭ToolStripMenuItem.Name = "히스토그램스트레칭ToolStripMenuItem";
            this.히스토그램스트레칭ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.히스토그램스트레칭ToolStripMenuItem.Text = "히스토그램 스트레칭";
            // 
            // 앤드인탐색ToolStripMenuItem
            // 
            this.앤드인탐색ToolStripMenuItem.Name = "앤드인탐색ToolStripMenuItem";
            this.앤드인탐색ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.앤드인탐색ToolStripMenuItem.Text = "앤드인 탐색";
            // 
            // 히스토그램평활화ToolStripMenuItem
            // 
            this.히스토그램평활화ToolStripMenuItem.Name = "히스토그램평활화ToolStripMenuItem";
            this.히스토그램평활화ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.히스토그램평활화ToolStripMenuItem.Text = "히스토그램 평활화";
            this.히스토그램평활화ToolStripMenuItem.Click += new System.EventHandler(this.히스토그램평활화ToolStripMenuItem_Click);
            // 
            // 영상처리ToolStripMenuItem
            // 
            this.영상처리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.동일이미지ToolStripMenuItem,
            this.밝게하기ToolStripMenuItem,
            this.흑백ToolStripMenuItem,
            this.화면ToolStripMenuItem,
            this.감마변환ToolStripMenuItem,
            this.파라볼라ToolStripMenuItem});
            this.영상처리ToolStripMenuItem.Name = "영상처리ToolStripMenuItem";
            this.영상처리ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.영상처리ToolStripMenuItem.Text = "영상처리";
            // 
            // 동일이미지ToolStripMenuItem
            // 
            this.동일이미지ToolStripMenuItem.Name = "동일이미지ToolStripMenuItem";
            this.동일이미지ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.동일이미지ToolStripMenuItem.Text = "동일이미지";
            this.동일이미지ToolStripMenuItem.Click += new System.EventHandler(this.동일이미지ToolStripMenuItem_Click);
            // 
            // 밝게하기ToolStripMenuItem
            // 
            this.밝게하기ToolStripMenuItem.Name = "밝게하기ToolStripMenuItem";
            this.밝게하기ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.밝게하기ToolStripMenuItem.Text = "밝게하기";
            this.밝게하기ToolStripMenuItem.Click += new System.EventHandler(this.밝게하기ToolStripMenuItem_Click);
            // 
            // 흑백ToolStripMenuItem
            // 
            this.흑백ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기준127ToolStripMenuItem,
            this.중위수ToolStripMenuItem,
            this.평균값ToolStripMenuItem});
            this.흑백ToolStripMenuItem.Name = "흑백ToolStripMenuItem";
            this.흑백ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.흑백ToolStripMenuItem.Text = "흑백";
            // 
            // 기준127ToolStripMenuItem
            // 
            this.기준127ToolStripMenuItem.Name = "기준127ToolStripMenuItem";
            this.기준127ToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.기준127ToolStripMenuItem.Text = "기준(127)";
            this.기준127ToolStripMenuItem.Click += new System.EventHandler(this.기준127ToolStripMenuItem_Click);
            // 
            // 중위수ToolStripMenuItem
            // 
            this.중위수ToolStripMenuItem.Name = "중위수ToolStripMenuItem";
            this.중위수ToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.중위수ToolStripMenuItem.Text = "중위수";
            this.중위수ToolStripMenuItem.Click += new System.EventHandler(this.중위수ToolStripMenuItem_Click);
            // 
            // 평균값ToolStripMenuItem
            // 
            this.평균값ToolStripMenuItem.Name = "평균값ToolStripMenuItem";
            this.평균값ToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.평균값ToolStripMenuItem.Text = "평균값";
            this.평균값ToolStripMenuItem.Click += new System.EventHandler(this.평균값ToolStripMenuItem_Click);
            // 
            // 화면ToolStripMenuItem
            // 
            this.화면ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.확대ToolStripMenuItem,
            this.축소ToolStripMenuItem,
            this.좌우미러링ToolStripMenuItem,
            this.상하미러링ToolStripMenuItem,
            this.반전ToolStripMenuItem,
            this.화면확대역방향ToolStripMenuItem});
            this.화면ToolStripMenuItem.Name = "화면ToolStripMenuItem";
            this.화면ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.화면ToolStripMenuItem.Text = "화면";
            // 
            // 확대ToolStripMenuItem
            // 
            this.확대ToolStripMenuItem.Name = "확대ToolStripMenuItem";
            this.확대ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.확대ToolStripMenuItem.Text = "확대";
            // 
            // 축소ToolStripMenuItem
            // 
            this.축소ToolStripMenuItem.Name = "축소ToolStripMenuItem";
            this.축소ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.축소ToolStripMenuItem.Text = "축소";
            // 
            // 좌우미러링ToolStripMenuItem
            // 
            this.좌우미러링ToolStripMenuItem.Name = "좌우미러링ToolStripMenuItem";
            this.좌우미러링ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.좌우미러링ToolStripMenuItem.Text = "좌우미러링";
            // 
            // 상하미러링ToolStripMenuItem
            // 
            this.상하미러링ToolStripMenuItem.Name = "상하미러링ToolStripMenuItem";
            this.상하미러링ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.상하미러링ToolStripMenuItem.Text = "상하미러링";
            // 
            // 반전ToolStripMenuItem
            // 
            this.반전ToolStripMenuItem.Name = "반전ToolStripMenuItem";
            this.반전ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.반전ToolStripMenuItem.Text = "반전";
            // 
            // 화면확대역방향ToolStripMenuItem
            // 
            this.화면확대역방향ToolStripMenuItem.Name = "화면확대역방향ToolStripMenuItem";
            this.화면확대역방향ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.화면확대역방향ToolStripMenuItem.Text = "화면확대역방향";
            // 
            // 감마변환ToolStripMenuItem
            // 
            this.감마변환ToolStripMenuItem.Name = "감마변환ToolStripMenuItem";
            this.감마변환ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.감마변환ToolStripMenuItem.Text = "감마변환";
            // 
            // 파라볼라ToolStripMenuItem
            // 
            this.파라볼라ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraCabToolStripMenuItem});
            this.파라볼라ToolStripMenuItem.Name = "파라볼라ToolStripMenuItem";
            this.파라볼라ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.파라볼라ToolStripMenuItem.Text = "파라볼라";
            // 
            // paraCabToolStripMenuItem
            // 
            this.paraCabToolStripMenuItem.Name = "paraCabToolStripMenuItem";
            this.paraCabToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.paraCabToolStripMenuItem.Text = "paraCab";
            this.paraCabToolStripMenuItem.Click += new System.EventHandler(this.paraCabToolStripMenuItem_Click);
            // 
            // 화소영역ToolStripMenuItem
            // 
            this.화소영역ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.엠보싱ToolStripMenuItem,
            this.블러링ToolStripMenuItem,
            this.모폴로ToolStripMenuItem});
            this.화소영역ToolStripMenuItem.Name = "화소영역ToolStripMenuItem";
            this.화소영역ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.화소영역ToolStripMenuItem.Text = "화소영역";
            // 
            // 엠보싱ToolStripMenuItem
            // 
            this.엠보싱ToolStripMenuItem.Name = "엠보싱ToolStripMenuItem";
            this.엠보싱ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.엠보싱ToolStripMenuItem.Text = "엠보싱";
            this.엠보싱ToolStripMenuItem.Click += new System.EventHandler(this.엠보싱ToolStripMenuItem_Click);
            // 
            // 블러링ToolStripMenuItem
            // 
            this.블러링ToolStripMenuItem.Name = "블러링ToolStripMenuItem";
            this.블러링ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.블러링ToolStripMenuItem.Text = "블러링";
            this.블러링ToolStripMenuItem.Click += new System.EventHandler(this.블러링ToolStripMenuItem_Click);
            // 
            // 모폴로ToolStripMenuItem
            // 
            this.모폴로ToolStripMenuItem.Name = "모폴로ToolStripMenuItem";
            this.모폴로ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.모폴로ToolStripMenuItem.Text = "모폴로지";
            this.모폴로ToolStripMenuItem.Click += new System.EventHandler(this.모폴로ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_size});
            this.statusStrip1.Location = new System.Drawing.Point(0, 592);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(638, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tool_size
            // 
            this.tool_size.Name = "tool_size";
            this.tool_size.Size = new System.Drawing.Size(54, 20);
            this.tool_size.Text = "해상도";
            // 
            // pb_photo
            // 
            this.pb_photo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_photo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_photo.Location = new System.Drawing.Point(0, 28);
            this.pb_photo.Name = "pb_photo";
            this.pb_photo.Size = new System.Drawing.Size(582, 564);
            this.pb_photo.TabIndex = 2;
            this.pb_photo.TabStop = false;
            this.pb_photo.Click += new System.EventHandler(this.pb_photo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 617);
            this.Controls.Add(this.pb_photo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 히스토그램ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 히스토그램스트레칭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 앤드인탐색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 히스토그램평활화ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tool_size;
        private System.Windows.Forms.PictureBox pb_photo;
        private System.Windows.Forms.ToolStripMenuItem 영상처리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 동일이미지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 화소영역ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 엠보싱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 블러링ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 밝게하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 흑백ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기준127ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 중위수ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 평균값ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 화면ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확대ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 축소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 좌우미러링ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상하미러링ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 반전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 화면확대역방향ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 감마변환ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모폴로ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파라볼라ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraCabToolStripMenuItem;
    }
}

