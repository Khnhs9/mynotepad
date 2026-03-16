namespace MyNotepad
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEditor = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            보기VToolStripMenuItem = new ToolStripMenuItem();
            도움말ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            폐이지설정UToolStripMenuItem = new ToolStripMenuItem();
            연쇄PToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            끝내기XToolStripMenuItem = new ToolStripMenuItem();
            실행취소UToolStripMenuItem = new ToolStripMenuItem();
            잘라내기TToolStripMenuItem = new ToolStripMenuItem();
            복사CToolStripMenuItem = new ToolStripMenuItem();
            붙여넣기PToolStripMenuItem = new ToolStripMenuItem();
            삭제LToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            bing으로검색SToolStripMenuItem = new ToolStripMenuItem();
            찾기FToolStripMenuItem = new ToolStripMenuItem();
            다음찾기NToolStripMenuItem = new ToolStripMenuItem();
            바꾸기RToolStripMenuItem = new ToolStripMenuItem();
            이동GToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            모두선택AToolStripMenuItem = new ToolStripMenuItem();
            시간날짜DToolStripMenuItem = new ToolStripMenuItem();
            자동줄바꿈WToolStripMenuItem = new ToolStripMenuItem();
            글꼴FToolStripMenuItem = new ToolStripMenuItem();
            확대하기축소하기ToolStripMenuItem = new ToolStripMenuItem();
            상태표시줄SToolStripMenuItem = new ToolStripMenuItem();
            도움말보기HToolStripMenuItem = new ToolStripMenuItem();
            메모장정보AToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEditor
            // 
            txtEditor.AcceptsTab = true;
            txtEditor.Dock = DockStyle.Fill;
            txtEditor.Location = new Point(0, 28);
            txtEditor.Multiline = true;
            txtEditor.Name = "txtEditor";
            txtEditor.ScrollBars = ScrollBars.Both;
            txtEditor.Size = new Size(800, 422);
            txtEditor.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem, 보기VToolStripMenuItem, 도움말ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem, toolStripMenuItem1, 폐이지설정UToolStripMenuItem, 연쇄PToolStripMenuItem, toolStripMenuItem2, 끝내기XToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(70, 24);
            fileToolStripMenuItem.Text = "파일(F)";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(224, 26);
            newToolStripMenuItem.Text = "새로 만들기(N)";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "열기(O)...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(249, 26);
            saveToolStripMenuItem.Text = "저장(S)";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(249, 26);
            exitToolStripMenuItem.Text = "다른 이름으로 저장(A),,,";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 실행취소UToolStripMenuItem, 잘라내기TToolStripMenuItem, 복사CToolStripMenuItem, 붙여넣기PToolStripMenuItem, 삭제LToolStripMenuItem, toolStripMenuItem3, bing으로검색SToolStripMenuItem, 찾기FToolStripMenuItem, 다음찾기NToolStripMenuItem, 바꾸기RToolStripMenuItem, 이동GToolStripMenuItem, toolStripMenuItem4, 모두선택AToolStripMenuItem, 시간날짜DToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(71, 24);
            editToolStripMenuItem.Text = "편집(E)";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 자동줄바꿈WToolStripMenuItem, 글꼴FToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(74, 24);
            helpToolStripMenuItem.Text = "서식(O)";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // 보기VToolStripMenuItem
            // 
            보기VToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 확대하기축소하기ToolStripMenuItem, 상태표시줄SToolStripMenuItem });
            보기VToolStripMenuItem.Name = "보기VToolStripMenuItem";
            보기VToolStripMenuItem.Size = new Size(72, 24);
            보기VToolStripMenuItem.Text = "보기(V)";
            // 
            // 도움말ToolStripMenuItem
            // 
            도움말ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 도움말보기HToolStripMenuItem, 메모장정보AToolStripMenuItem });
            도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            도움말ToolStripMenuItem.Size = new Size(68, 24);
            도움말ToolStripMenuItem.Text = "도움말";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(246, 6);
            // 
            // 폐이지설정UToolStripMenuItem
            // 
            폐이지설정UToolStripMenuItem.Name = "폐이지설정UToolStripMenuItem";
            폐이지설정UToolStripMenuItem.Size = new Size(249, 26);
            폐이지설정UToolStripMenuItem.Text = "폐이지 설정(U),,,";
            // 
            // 연쇄PToolStripMenuItem
            // 
            연쇄PToolStripMenuItem.Name = "연쇄PToolStripMenuItem";
            연쇄PToolStripMenuItem.Size = new Size(249, 26);
            연쇄PToolStripMenuItem.Text = "연쇄(P),,,";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(246, 6);
            // 
            // 끝내기XToolStripMenuItem
            // 
            끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem";
            끝내기XToolStripMenuItem.Size = new Size(249, 26);
            끝내기XToolStripMenuItem.Text = "끝내기(X)";
            // 
            // 실행취소UToolStripMenuItem
            // 
            실행취소UToolStripMenuItem.Name = "실행취소UToolStripMenuItem";
            실행취소UToolStripMenuItem.Size = new Size(224, 26);
            실행취소UToolStripMenuItem.Text = "실행 취소(U)  ";
            // 
            // 잘라내기TToolStripMenuItem
            // 
            잘라내기TToolStripMenuItem.Name = "잘라내기TToolStripMenuItem";
            잘라내기TToolStripMenuItem.Size = new Size(224, 26);
            잘라내기TToolStripMenuItem.Text = "잘라내기(T)";
            // 
            // 복사CToolStripMenuItem
            // 
            복사CToolStripMenuItem.Name = "복사CToolStripMenuItem";
            복사CToolStripMenuItem.Size = new Size(224, 26);
            복사CToolStripMenuItem.Text = "복사(C)";
            // 
            // 붙여넣기PToolStripMenuItem
            // 
            붙여넣기PToolStripMenuItem.Name = "붙여넣기PToolStripMenuItem";
            붙여넣기PToolStripMenuItem.Size = new Size(224, 26);
            붙여넣기PToolStripMenuItem.Text = "붙여넣기(P)  ";
            // 
            // 삭제LToolStripMenuItem
            // 
            삭제LToolStripMenuItem.Name = "삭제LToolStripMenuItem";
            삭제LToolStripMenuItem.Size = new Size(224, 26);
            삭제LToolStripMenuItem.Text = "삭제(L)   ";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(221, 6);
            // 
            // bing으로검색SToolStripMenuItem
            // 
            bing으로검색SToolStripMenuItem.Name = "bing으로검색SToolStripMenuItem";
            bing으로검색SToolStripMenuItem.Size = new Size(224, 26);
            bing으로검색SToolStripMenuItem.Text = "Bing으로 검색(S)… ";
            // 
            // 찾기FToolStripMenuItem
            // 
            찾기FToolStripMenuItem.Name = "찾기FToolStripMenuItem";
            찾기FToolStripMenuItem.Size = new Size(224, 26);
            찾기FToolStripMenuItem.Text = "찾기(F)…  ";
            // 
            // 다음찾기NToolStripMenuItem
            // 
            다음찾기NToolStripMenuItem.Name = "다음찾기NToolStripMenuItem";
            다음찾기NToolStripMenuItem.Size = new Size(224, 26);
            다음찾기NToolStripMenuItem.Text = "다음 찾기(N) ";
            // 
            // 바꾸기RToolStripMenuItem
            // 
            바꾸기RToolStripMenuItem.Name = "바꾸기RToolStripMenuItem";
            바꾸기RToolStripMenuItem.Size = new Size(224, 26);
            바꾸기RToolStripMenuItem.Text = "바꾸기(R)… ";
            // 
            // 이동GToolStripMenuItem
            // 
            이동GToolStripMenuItem.Name = "이동GToolStripMenuItem";
            이동GToolStripMenuItem.Size = new Size(224, 26);
            이동GToolStripMenuItem.Text = "이동(G)…   ";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(221, 6);
            // 
            // 모두선택AToolStripMenuItem
            // 
            모두선택AToolStripMenuItem.Name = "모두선택AToolStripMenuItem";
            모두선택AToolStripMenuItem.Size = new Size(224, 26);
            모두선택AToolStripMenuItem.Text = "모두 선택(A) ";
            // 
            // 시간날짜DToolStripMenuItem
            // 
            시간날짜DToolStripMenuItem.Name = "시간날짜DToolStripMenuItem";
            시간날짜DToolStripMenuItem.Size = new Size(224, 26);
            시간날짜DToolStripMenuItem.Text = "시간/날짜(D)  ";
            // 
            // 자동줄바꿈WToolStripMenuItem
            // 
            자동줄바꿈WToolStripMenuItem.Name = "자동줄바꿈WToolStripMenuItem";
            자동줄바꿈WToolStripMenuItem.Size = new Size(199, 26);
            자동줄바꿈WToolStripMenuItem.Text = "자동 줄 바꿈(W)";
            // 
            // 글꼴FToolStripMenuItem
            // 
            글꼴FToolStripMenuItem.Name = "글꼴FToolStripMenuItem";
            글꼴FToolStripMenuItem.Size = new Size(199, 26);
            글꼴FToolStripMenuItem.Text = "글꼴(F)…";
            // 
            // 확대하기축소하기ToolStripMenuItem
            // 
            확대하기축소하기ToolStripMenuItem.Name = "확대하기축소하기ToolStripMenuItem";
            확대하기축소하기ToolStripMenuItem.Size = new Size(224, 26);
            확대하기축소하기ToolStripMenuItem.Text = "확대하기/축소하기";
            // 
            // 상태표시줄SToolStripMenuItem
            // 
            상태표시줄SToolStripMenuItem.Name = "상태표시줄SToolStripMenuItem";
            상태표시줄SToolStripMenuItem.Size = new Size(224, 26);
            상태표시줄SToolStripMenuItem.Text = "상태 표시줄(S)";
            // 
            // 도움말보기HToolStripMenuItem
            // 
            도움말보기HToolStripMenuItem.Name = "도움말보기HToolStripMenuItem";
            도움말보기HToolStripMenuItem.Size = new Size(224, 26);
            도움말보기HToolStripMenuItem.Text = "도움말 보기(H)";
            // 
            // 메모장정보AToolStripMenuItem
            // 
            메모장정보AToolStripMenuItem.Name = "메모장정보AToolStripMenuItem";
            메모장정보AToolStripMenuItem.Size = new Size(224, 26);
            메모장정보AToolStripMenuItem.Text = "메모장 정보(A)";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEditor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MyNotepad V1.0";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEditor;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem 보기VToolStripMenuItem;
        private ToolStripMenuItem 도움말ToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem 폐이지설정UToolStripMenuItem;
        private ToolStripMenuItem 연쇄PToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem 끝내기XToolStripMenuItem;
        private ToolStripMenuItem 실행취소UToolStripMenuItem;
        private ToolStripMenuItem 잘라내기TToolStripMenuItem;
        private ToolStripMenuItem 복사CToolStripMenuItem;
        private ToolStripMenuItem 붙여넣기PToolStripMenuItem;
        private ToolStripMenuItem 삭제LToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem bing으로검색SToolStripMenuItem;
        private ToolStripMenuItem 찾기FToolStripMenuItem;
        private ToolStripMenuItem 다음찾기NToolStripMenuItem;
        private ToolStripMenuItem 바꾸기RToolStripMenuItem;
        private ToolStripMenuItem 이동GToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem 모두선택AToolStripMenuItem;
        private ToolStripMenuItem 시간날짜DToolStripMenuItem;
        private ToolStripMenuItem 자동줄바꿈WToolStripMenuItem;
        private ToolStripMenuItem 글꼴FToolStripMenuItem;
        private ToolStripMenuItem 확대하기축소하기ToolStripMenuItem;
        private ToolStripMenuItem 상태표시줄SToolStripMenuItem;
        private ToolStripMenuItem 도움말보기HToolStripMenuItem;
        private ToolStripMenuItem 메모장정보AToolStripMenuItem;
    }
}
