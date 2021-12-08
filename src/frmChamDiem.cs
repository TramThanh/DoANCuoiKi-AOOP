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
using System.IO;

namespace src
{
    public partial class frmChamDiem : Form
    {
        BindingList<BaiNop> lstBaiNop = new BindingList<BaiNop>();
        BindingList<BaiNop> lstDapAn = new BindingList<BaiNop>();
        BindingList<KetQuaThi> lstKetQua = new BindingList<KetQuaThi>();
        public frmChamDiem()
        {
            InitializeComponent();
        }

        private void frmChamDiem_Load(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Chon file .xml|*xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlg.FileName;
                XmlReader reader = XmlReader.Create(filePath);

                reader.ReadToFollowing("hoten");
                txtName.Text = reader.ReadElementContentAsString();
                reader.ReadToFollowing("linhvuc");
                txtField.Text = reader.ReadElementContentAsString();
                while (reader.ReadToFollowing("cauhoi"))
                {
                    BaiNop bainop = new BaiNop();

                    reader.ReadToFollowing("noidung");
                    bainop.CauHoi = reader.ReadElementContentAsString();
                    reader.ReadToFollowing("cautraloi");
                    bainop.CauTraLoi = reader.ReadElementContentAsString();
                    lstBaiNop.Add(bainop);
                    lbxBaiThi.DataSource = lstBaiNop;
                }
                reader.Close();
            }

            if (txtField.Text == "Bảo Mật")
            {
                LoadDapAnBaoMat();
            }
            else if (txtField.Text == "Phần Mềm")
            {
                LoadDapAnPhanMem();
            }
            else if (txtField.Text == "Phần Cứng")
            {
                LoadDapAnPhanCung();
            }
            else if (txtField.Text == "Mạng")
            {
                LoadDapAnMang();
            }
        }

        private void LoadDapAnPhanCung()
        {
            XmlReader reader = XmlReader.Create(@"C:\Users\Admin\source\repos\2059054\src\DapAnDePhanCung.xml");
            while (reader.ReadToFollowing("de"))
            {
                BaiNop bainop = new BaiNop();
                reader.ReadToFollowing("noidung");
                bainop.CauHoi = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapan");
                bainop.CauTraLoi = reader.ReadElementContentAsString();
                lstDapAn.Add(bainop);
            }
            reader.Close();
        }

        private void LoadDapAnPhanMem()
        {
            XmlReader reader = XmlReader.Create(@"C:\Users\Admin\source\repos\2059054\src\DapAnDePhanMem.xml");
            while (reader.ReadToFollowing("de"))
            {
                BaiNop bainop = new BaiNop();
                reader.ReadToFollowing("noidung");
                bainop.CauHoi = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapan");
                bainop.CauTraLoi = reader.ReadElementContentAsString();
                lstDapAn.Add(bainop);
            }
            reader.Close();
        }

        private void LoadDapAnMang()
        {
            XmlReader reader = XmlReader.Create(@"C:\Users\Admin\source\repos\2059054\src\DapAnDeMang.xml");
            while (reader.ReadToFollowing("de"))
            {
                BaiNop bainop = new BaiNop();
                reader.ReadToFollowing("noidung");
                bainop.CauHoi = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapan");
                bainop.CauTraLoi = reader.ReadElementContentAsString();
                lstDapAn.Add(bainop);
            }
            reader.Close();
        }

        private void LoadDapAnBaoMat()
        {
            XmlReader reader = XmlReader.Create(@"C:\Users\Admin\source\repos\2059054\src\DapAnBaoMat.xml");
            while (reader.ReadToFollowing("de"))
            {
                BaiNop bainop = new BaiNop();
                reader.ReadToFollowing("noidung");
                bainop.CauHoi = reader.ReadElementContentAsString();
                reader.ReadToFollowing("dapan");
                bainop.CauTraLoi = reader.ReadElementContentAsString();
                lstDapAn.Add(bainop);
            }
            reader.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter writer = File.CreateText(@"C:\Users\Admin\source\repos\2059054\src\FileDiem.txt");
            foreach (KetQuaThi kq in lstKetQua)
            {
                String sOject = kq.HoTen + " - " + kq.LinhVuc + " - " + kq.DiemThi;
                writer.WriteLine(sOject);
            }
            writer.Close();
            this.Visible = false;
        }
    }
}
