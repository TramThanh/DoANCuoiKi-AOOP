using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

/*
 * Thong tin ca nhan
MSSV: 2059054 
Ho Ten: Tram Thi Tuyet Thanh 
Dia chi mail: 2059054@itec.hcmus.edu.vn
Github: 
 */

namespace src
{
    public partial class frmThi : Form
    {
        BindingList<DeThi> lstDeThiPhanCung = new BindingList<DeThi>();
        BindingList<DeThi> lstDeThiPhanMem = new BindingList<DeThi>();
        BindingList<DeThi> lstDeThiMang = new BindingList<DeThi>();
        BindingList<DeThi> lstDeThiBaoMat = new BindingList<DeThi>();
        BindingList<String> lstCauTraLoi = new BindingList<string>();

        BindingList<BaiNop> lstBaiNop = new BindingList<BaiNop>();
        public frmThi()
        {
            InitializeComponent();
        }

        private void LoadDePhanCung()
        {
            XmlReader reader = XmlReader.Create(@"C:\Users\Admin\source\repos\2059054\src\DePhanCung.xml");
            while (reader.ReadToFollowing("de"))
            {
                DeThi dethi = new DeThi();
                reader.ReadToFollowing("noidung");
                dethi.NoiDung = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapanA");
                dethi.DapAnA = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapanB");
                dethi.DapAnB = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapanC");
                dethi.DapAnC = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapanD");
                dethi.DapAnD = reader.ReadElementContentAsString();
                lstDeThiPhanCung.Add(dethi);

                String sLine = lstDeThiPhanCung[0].ToString();
                String[] arrDeThi = sLine.Split('|');
                lblQuestion.Text = arrDeThi[0];
                lblA.Text = arrDeThi[1];
                lblB.Text = arrDeThi[2];
                lblC.Text = arrDeThi[3];
                lblD.Text = arrDeThi[4];

                lbCauHoi.SelectedIndex = 0;
            }
            reader.Close();
        }

        private void LoadDeThiPhanMem()
        {
            XmlReader reader = XmlReader.Create(@"C:\Users\Admin\source\repos\2059054\src\DePhanMem.xml");
            while (reader.ReadToFollowing("de"))
            {
                DeThi dethi = new DeThi();
                reader.ReadToFollowing("noidung");
                dethi.NoiDung = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapanA");
                dethi.DapAnA = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapanB");
                dethi.DapAnB = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapanC");
                dethi.DapAnC = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapanD");
                dethi.DapAnD = reader.ReadElementContentAsString();
                lstDeThiPhanMem.Add(dethi);

                String sLine = lstDeThiPhanMem[0].ToString();
                String[] arrDeThi = sLine.Split('|');
                lblQuestion.Text = arrDeThi[0];
                lblA.Text = arrDeThi[1];
                lblB.Text = arrDeThi[2];
                lblC.Text = arrDeThi[3];
                lblD.Text = arrDeThi[4];

                lbCauHoi.SelectedIndex = 0;
            }
            reader.Close();
        }

        private void LoadDeThiMang()
        {
            XmlReader reader = XmlReader.Create(@"C:\Users\Admin\source\repos\2059054\src\DeMang.xml");
            while (reader.ReadToFollowing("de"))
            {
                DeThi dethi = new DeThi();
                reader.ReadToFollowing("noidung");
                dethi.NoiDung = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapanA");
                dethi.DapAnA = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapanB");
                dethi.DapAnB = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapanC");
                dethi.DapAnC = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapanD");
                dethi.DapAnD = reader.ReadElementContentAsString();
                lstDeThiMang.Add(dethi);

                String sLine = lstDeThiMang[0].ToString();
                String[] arrDeThi = sLine.Split('|');
                lblQuestion.Text = arrDeThi[0];
                lblA.Text = arrDeThi[1];
                lblB.Text = arrDeThi[2];
                lblC.Text = arrDeThi[3];
                lblD.Text = arrDeThi[4];

                lbCauHoi.SelectedIndex = 0;
            }
            reader.Close();
        }

        private void LoadDeThiBaoMat()
        {
            XmlReader reader = XmlReader.Create(@"C:\Users\Admin\source\repos\2059054\src\DeBaoMat.xml");
            while (reader.ReadToFollowing("de"))
            {
                DeThi dethi = new DeThi();
                reader.ReadToFollowing("noidung");
                dethi.NoiDung = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapanA");
                dethi.DapAnA = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapanB");
                dethi.DapAnB = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapanC");
                dethi.DapAnC = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapanD");
                dethi.DapAnD = reader.ReadElementContentAsString();
                lstDeThiBaoMat.Add(dethi);

                String sLine = lstDeThiBaoMat[0].ToString();
                String[] arrDeThi = sLine.Split('|');
                lblQuestion.Text = arrDeThi[0];
                lblA.Text = arrDeThi[1];
                lblB.Text = arrDeThi[2];
                lblC.Text = arrDeThi[3];
                lblD.Text = arrDeThi[4];

                lbCauHoi.SelectedIndex = 0;
            }
            reader.Close();
        }

        private void cbxLinhVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbxLinhVuc.SelectedIndex;
            if(index ==0)
            {
                LoadDePhanCung();
            }
            else if(index == 1)
            {
                LoadDeThiPhanMem();
            }
            else if(index ==2)
            {
                LoadDeThiMang();
            }
            else if(index ==3)
            {
                LoadDeThiBaoMat();
            }    
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int index = lbCauHoi.SelectedIndex;
            if(lbxCauTL.SelectedItem.ToString() !="")
            {
                if (index > 0 && index <= 19)
                {
                    lbCauHoi.SelectedIndex -= 1;
                    lbxCauTL.SelectedIndex = lbCauHoi.SelectedIndex;
                }
                else if (index == 0)
                {
                    lbCauHoi.SelectedIndex = 19;
                    lbxCauTL.SelectedIndex = 19;
                }
            }
            else if(lbxCauTL.SelectedItem.ToString() =="")
            {
                if (index > 0 && index <= 19)
                {
                    lbCauHoi.SelectedIndex -= 1;
                    lbxCauTL.SelectedIndex = lbCauHoi.SelectedIndex;
                }
                else if (index == 0)
                {
                    lbCauHoi.SelectedIndex = 19;
                    lbxCauTL.SelectedIndex = lbCauHoi.SelectedIndex - 1;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int index = lbCauHoi.SelectedIndex;
                if (index >= 0 && index < 19)
                {
                    lbCauHoi.SelectedIndex += 1;
                    //lbxCauTL.SelectedIndex = lbCauHoi.SelectedIndex;
                }
                else if (index == 19)
                {
                    lbCauHoi.SelectedIndex = 0;
                    //lbxCauTL.SelectedIndex = lbCauHoi.SelectedIndex;
                }
        }

        private void lbCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _index = cbxLinhVuc.SelectedIndex;
            int index = lbCauHoi.SelectedIndex;
            if(_index ==0)
            {
                String sLine = lstDeThiPhanCung[index].ToString();
                String[] arrDeThi = sLine.Split('|');
                lblQuestion.Text = arrDeThi[0];
                lblA.Text = arrDeThi[1];
                lblB.Text = arrDeThi[2];
                lblC.Text = arrDeThi[3];
                lblD.Text = arrDeThi[4];
            }
            else if(_index ==1)
            {
                String sLine = lstDeThiPhanMem[index].ToString();
                String[] arrDeThi = sLine.Split('|');
                lblQuestion.Text = arrDeThi[0];
                lblA.Text = arrDeThi[1];
                lblB.Text = arrDeThi[2];
                lblC.Text = arrDeThi[3];
                lblD.Text = arrDeThi[4];
            }
            else if(_index ==2)
            {
                String sLine = lstDeThiMang[index].ToString();
                String[] arrDeThi = sLine.Split('|');
                lblQuestion.Text = arrDeThi[0];
                lblA.Text = arrDeThi[1];
                lblB.Text = arrDeThi[2];
                lblC.Text = arrDeThi[3];
                lblD.Text = arrDeThi[4];
            }
            else if(_index ==3)
            {
                String sLine = lstDeThiBaoMat[index].ToString();
                String[] arrDeThi = sLine.Split('|');
                lblQuestion.Text = arrDeThi[0];
                lblA.Text = arrDeThi[1];
                lblB.Text = arrDeThi[2];
                lblC.Text = arrDeThi[3];
                lblD.Text = arrDeThi[4];
            }
            lblQuesNum.Text =Convert.ToString(index + 1) + ".";
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if(txtName.Text =="")
            {
                MessageBox.Show("Chua dien ho ten", "Thong bao", MessageBoxButtons.OK);
            }
            else if(txtName.Text !="")
            {
                if (MessageBox.Show("Nộp Bài?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes && txtName.Text != "")
                {
                    LuuBaiThi();
                    this.Visible = false;
                }
            }
        }

        private void frmThi_Load(object sender, EventArgs e)
        {
        }

        private void LuuBaiThi()
        {
            XmlWriter writer = XmlWriter.Create(@"C:\Users\Admin\source\repos\2059054\src\NopBai.xml", new XmlWriterSettings() { Indent = true });
            writer.WriteStartElement("bainop");

            writer.WriteStartElement("hoten");
            writer.WriteValue(txtName.Text);
            writer.WriteEndElement();

            writer.WriteStartElement("linhvuc");
            writer.WriteValue(cbxLinhVuc.SelectedItem.ToString());
            writer.WriteEndElement();

            foreach (BaiNop bainop in lstBaiNop)
            {
                writer.WriteStartElement("cauhoi");

                writer.WriteStartElement("noidung");
                writer.WriteValue(bainop.CauHoi);
                writer.WriteEndElement();

                writer.WriteStartElement("cautraloi");
                writer.WriteValue(bainop.CauTraLoi);
                writer.WriteEndElement();

                writer.WriteEndElement();

            }
            writer.WriteEndElement();
            writer.Close();
        }

        private void Reset()
        {
            rbtnA.Checked = false;
            rbtnB.Checked = false;
            rbtnC.Checked = false;
            rbtnD.Checked = false;
        }

        private void gbxAnswers_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnD_CheckedChanged(object sender, EventArgs e)
        {
            int index = lbCauHoi.SelectedIndex;
            if (rbtnA.Checked == true)
            {
                BaiNop bainop = new BaiNop();
                bainop.CauHoi = lblQuesNum.Text;
                bainop.CauTraLoi = rbtnA.Text;
                lstBaiNop.Add(bainop);

                lbxCauTL.SelectedItem = "A";
                lstCauTraLoi.Add("A");
                lbxCauTL.DataSource = lstCauTraLoi;

                lbxCauTL.SelectedIndex = index;

                Reset();
            }
            else if (rbtnB.Checked == true)
            {
                BaiNop bainop = new BaiNop();
                bainop.CauHoi = lblQuesNum.Text;
                bainop.CauTraLoi = rbtnB.Text;
                lstBaiNop.Add(bainop);

                lstCauTraLoi.Add("B");
                lbxCauTL.DataSource = lstCauTraLoi;

                lbxCauTL.SelectedIndex = index;

                Reset();
            }
            else if (rbtnC.Checked == true)
            {
                BaiNop bainop = new BaiNop();
                bainop.CauHoi = lblQuesNum.Text;
                bainop.CauTraLoi = rbtnC.Text;
                lstBaiNop.Add(bainop);

                lstCauTraLoi.Add("C");
                lbxCauTL.DataSource = lstCauTraLoi;

                lbxCauTL.SelectedIndex = index;

                Reset();
            }
            else if (rbtnD.Checked == true)
            {
                BaiNop bainop = new BaiNop();
                bainop.CauHoi = lblQuesNum.Text;
                bainop.CauTraLoi = rbtnD.Text;
                lstBaiNop.Add(bainop);

                lstCauTraLoi.Add("D");
                lbxCauTL.DataSource = lstCauTraLoi;

                lbxCauTL.SelectedIndex = index;

                Reset();
            }
        }

        private void lbxCauTL_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
