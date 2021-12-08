
namespace src
{
    partial class frmThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThi));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbxLinhVuc = new System.Windows.Forms.ComboBox();
            this.lbCauHoi = new System.Windows.Forms.ListBox();
            this.gbxThongTin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxButton = new System.Windows.Forms.GroupBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblQuesNum = new System.Windows.Forms.Label();
            this.gbxAnswers = new System.Windows.Forms.GroupBox();
            this.rbtnD = new System.Windows.Forms.RadioButton();
            this.rbtnC = new System.Windows.Forms.RadioButton();
            this.rbtnB = new System.Windows.Forms.RadioButton();
            this.rbtnA = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lbxCauTL = new System.Windows.Forms.ListBox();
            this.gbxThongTin.SuspendLayout();
            this.gbxButton.SuspendLayout();
            this.gbxAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(14, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ Tên ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(116, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 31);
            this.txtName.TabIndex = 1;
            // 
            // cbxLinhVuc
            // 
            this.cbxLinhVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLinhVuc.FormattingEnabled = true;
            this.cbxLinhVuc.Items.AddRange(new object[] {
            "Phần Cứng",
            "Phần Mềm",
            "Mạng",
            "Bảo Mật"});
            this.cbxLinhVuc.Location = new System.Drawing.Point(116, 54);
            this.cbxLinhVuc.Name = "cbxLinhVuc";
            this.cbxLinhVuc.Size = new System.Drawing.Size(290, 33);
            this.cbxLinhVuc.TabIndex = 2;
            this.cbxLinhVuc.SelectedIndexChanged += new System.EventHandler(this.cbxLinhVuc_SelectedIndexChanged);
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCauHoi.FormattingEnabled = true;
            this.lbCauHoi.ItemHeight = 25;
            this.lbCauHoi.Items.AddRange(new object[] {
            "Câu 1",
            "Câu 2",
            "Câu 3",
            "Câu 4",
            "Câu 5",
            "Câu 6",
            "Câu 7",
            "Câu 8",
            "Câu 9",
            "Câu 10",
            "Câu 11",
            "Câu 12",
            "Câu 13",
            "Câu 14",
            "Câu 15",
            "Câu 16",
            "Câu 17",
            "Câu 18",
            "Câu 19",
            "Câu 20"});
            this.lbCauHoi.Location = new System.Drawing.Point(682, 118);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(91, 504);
            this.lbCauHoi.TabIndex = 3;
            this.lbCauHoi.SelectedIndexChanged += new System.EventHandler(this.lbCauHoi_SelectedIndexChanged);
            // 
            // gbxThongTin
            // 
            this.gbxThongTin.Controls.Add(this.label2);
            this.gbxThongTin.Controls.Add(this.lblName);
            this.gbxThongTin.Controls.Add(this.cbxLinhVuc);
            this.gbxThongTin.Controls.Add(this.txtName);
            this.gbxThongTin.Location = new System.Drawing.Point(12, 12);
            this.gbxThongTin.Name = "gbxThongTin";
            this.gbxThongTin.Size = new System.Drawing.Size(412, 100);
            this.gbxThongTin.TabIndex = 4;
            this.gbxThongTin.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phần Thi";
            // 
            // gbxButton
            // 
            this.gbxButton.Controls.Add(this.btnFinish);
            this.gbxButton.Controls.Add(this.btnNext);
            this.gbxButton.Controls.Add(this.btnPrevious);
            this.gbxButton.Location = new System.Drawing.Point(170, 557);
            this.gbxButton.Name = "gbxButton";
            this.gbxButton.Size = new System.Drawing.Size(370, 58);
            this.gbxButton.TabIndex = 6;
            this.gbxButton.TabStop = false;
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(237, 19);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(107, 32);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Kết Thúc";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(124, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 32);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Câu Tiếp";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(11, 19);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(107, 32);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Câu Trước ";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblA
            // 
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(59, 169);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(581, 60);
            this.lblA.TabIndex = 9;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(59, 229);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(581, 60);
            this.lblB.TabIndex = 9;
            this.lblB.Text = "B";
            // 
            // lblD
            // 
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(59, 358);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(581, 60);
            this.lblD.TabIndex = 9;
            this.lblD.Text = "D";
            // 
            // lblC
            // 
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(59, 289);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(581, 60);
            this.lblC.TabIndex = 9;
            this.lblC.Text = "C";
            // 
            // lblQuesNum
            // 
            this.lblQuesNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuesNum.Location = new System.Drawing.Point(24, 42);
            this.lblQuesNum.Name = "lblQuesNum";
            this.lblQuesNum.Size = new System.Drawing.Size(78, 105);
            this.lblQuesNum.TabIndex = 10;
            this.lblQuesNum.Text = "Câu 10.";
            // 
            // gbxAnswers
            // 
            this.gbxAnswers.Controls.Add(this.rbtnD);
            this.gbxAnswers.Controls.Add(this.rbtnC);
            this.gbxAnswers.Controls.Add(this.rbtnB);
            this.gbxAnswers.Controls.Add(this.rbtnA);
            this.gbxAnswers.Controls.Add(this.lblD);
            this.gbxAnswers.Controls.Add(this.lblA);
            this.gbxAnswers.Controls.Add(this.lblB);
            this.gbxAnswers.Controls.Add(this.lblC);
            this.gbxAnswers.Controls.Add(this.lblQuestion);
            this.gbxAnswers.Controls.Add(this.lblQuesNum);
            this.gbxAnswers.Location = new System.Drawing.Point(12, 118);
            this.gbxAnswers.Name = "gbxAnswers";
            this.gbxAnswers.Size = new System.Drawing.Size(664, 433);
            this.gbxAnswers.TabIndex = 11;
            this.gbxAnswers.TabStop = false;
            this.gbxAnswers.Enter += new System.EventHandler(this.gbxAnswers_Enter);
            // 
            // rbtnD
            // 
            this.rbtnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnD.Location = new System.Drawing.Point(6, 340);
            this.rbtnD.Name = "rbtnD";
            this.rbtnD.Size = new System.Drawing.Size(47, 60);
            this.rbtnD.TabIndex = 12;
            this.rbtnD.TabStop = true;
            this.rbtnD.Text = "D.";
            this.rbtnD.UseVisualStyleBackColor = true;
            this.rbtnD.CheckedChanged += new System.EventHandler(this.rbtnD_CheckedChanged);
            // 
            // rbtnC
            // 
            this.rbtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnC.Location = new System.Drawing.Point(6, 271);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(47, 60);
            this.rbtnC.TabIndex = 12;
            this.rbtnC.TabStop = true;
            this.rbtnC.Text = "C.";
            this.rbtnC.UseVisualStyleBackColor = true;
            this.rbtnC.CheckedChanged += new System.EventHandler(this.rbtnD_CheckedChanged);
            // 
            // rbtnB
            // 
            this.rbtnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnB.Location = new System.Drawing.Point(5, 211);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(47, 60);
            this.rbtnB.TabIndex = 12;
            this.rbtnB.TabStop = true;
            this.rbtnB.Text = "B.";
            this.rbtnB.UseVisualStyleBackColor = true;
            this.rbtnB.CheckedChanged += new System.EventHandler(this.rbtnD_CheckedChanged);
            // 
            // rbtnA
            // 
            this.rbtnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnA.Location = new System.Drawing.Point(6, 151);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(47, 60);
            this.rbtnA.TabIndex = 12;
            this.rbtnA.TabStop = true;
            this.rbtnA.Text = "A.";
            this.rbtnA.UseVisualStyleBackColor = true;
            this.rbtnA.CheckedChanged += new System.EventHandler(this.rbtnD_CheckedChanged);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(99, 42);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(547, 105);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "Câu Hỏi";
            // 
            // lbxCauTL
            // 
            this.lbxCauTL.BackColor = System.Drawing.SystemColors.Window;
            this.lbxCauTL.Enabled = false;
            this.lbxCauTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCauTL.FormattingEnabled = true;
            this.lbxCauTL.ItemHeight = 25;
            this.lbxCauTL.Location = new System.Drawing.Point(780, 118);
            this.lbxCauTL.Name = "lbxCauTL";
            this.lbxCauTL.Size = new System.Drawing.Size(74, 504);
            this.lbxCauTL.TabIndex = 12;
            this.lbxCauTL.SelectedIndexChanged += new System.EventHandler(this.lbxCauTL_SelectedIndexChanged);
            // 
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 627);
            this.Controls.Add(this.lbxCauTL);
            this.Controls.Add(this.gbxAnswers);
            this.Controls.Add(this.gbxButton);
            this.Controls.Add(this.gbxThongTin);
            this.Controls.Add(this.lbCauHoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThi";
            this.Text = "Bài Thi";
            this.Load += new System.EventHandler(this.frmThi_Load);
            this.gbxThongTin.ResumeLayout(false);
            this.gbxThongTin.PerformLayout();
            this.gbxButton.ResumeLayout(false);
            this.gbxAnswers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbxLinhVuc;
        private System.Windows.Forms.ListBox lbCauHoi;
        private System.Windows.Forms.GroupBox gbxThongTin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxButton;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblQuesNum;
        private System.Windows.Forms.GroupBox gbxAnswers;
        private System.Windows.Forms.RadioButton rbtnD;
        private System.Windows.Forms.RadioButton rbtnC;
        private System.Windows.Forms.RadioButton rbtnB;
        private System.Windows.Forms.RadioButton rbtnA;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.ListBox lbxCauTL;
    }
}