using Crawler.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Management : Form
    {
        private List<LinkDTO> ListLinkDTO = new List<LinkDTO>();
        public Management()
        {
            InitializeComponent();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            lbID.Text = "";
            lbSubID.Text = "";
            gbSubLink.Enabled = false;
            ListLinkDTO = FromEvents.GetListLinkDTO();
            LoadLinkDTOToListView(ListLinkDTO);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbName.Text) && !string.IsNullOrEmpty(tbURL.Text))
            {
                LinkDTO dto = new LinkDTO()
                {
                    ID = lbID.Text,
                    Name = tbName.Text,
                    Link = tbURL.Text,
                    IsRun = cbRun.Checked
                };
                InsertOrUpdateLinkDTO(dto);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbID.Text))
            {
                bool isOK = FromEvents.DeleteLinkDTO(lbID.Text);
                if (isOK) lbID.Text = "";
            }
        }

        private void btSubSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSubName.Text) && !string.IsNullOrEmpty(tbSubURL.Text) && !string.IsNullOrEmpty(tbXPathTitle.Text) && !string.IsNullOrEmpty(tbXPathDate.Text) && !string.IsNullOrEmpty(tbXPathContent.Text))
            {
                SubLinkDTO dto = new SubLinkDTO()
                {
                    ID = lbSubID.Text,
                    Name = tbSubName.Text,
                    SubLink = tbSubURL.Text,
                    IsRun = cbSubRun.Checked,
                    LinkID = lbID.Text,
                    XPathTitle = tbXPathTitle.Text,
                    XPathDate = tbXPathDate.Text,
                    XPathImage = tbXPathImage.Text,
                    XPathDescription = tbXPathDescription.Text,
                    XPathContent = tbXPathContent.Text
                };
                InsertOrUpdateSubLinkDTO(dto);
            }
        }

        private void btSubDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbSubID.Text))
            {
                bool isOK = FromEvents.DeleteLinkDTO(lbSubID.Text);
                if (isOK) lbSubID.Text = "";
            }
            else
                MessageBox.Show("aidhsa");
        }

        private void lvCrawlerLink_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCrawlerLink.SelectedIndices.Count > 0)
            {
                int index = lvCrawlerLink.SelectedIndices[0];
                string id = lvCrawlerLink.Items[index].Text;
                LoadLinkDTOSingle(FromEvents.GetLinkDTO(id, ListLinkDTO));
            }
        }

        private void lvSubLink_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSubLink.SelectedIndices.Count > 0)
            {
                int index = lvSubLink.SelectedIndices[0];
                string id = lvSubLink.Items[index].Text;
                var link = FromEvents.GetLinkDTO(lbID.Text, ListLinkDTO);
                LoadSubLinkDTOSingle(FromEvents.GetSubLinkDTO(id, link.ListSubLink));
            }
        }

        private void LoadLinkDTOSingle(LinkDTO dto)
        {
            lbID.Text = dto.ID;
            tbName.Text = dto.Name;
            tbURL.Text = dto.Link;
            cbRun.Checked = dto.IsRun;
        }

        private void LoadSubLinkDTOSingle(SubLinkDTO dto)
        {
            lbSubID.Text = dto.ID;
            tbSubName.Text = dto.Name;
            tbSubURL.Text = dto.SubLink;
            cbSubRun.Checked = dto.IsRun;
            tbXPathTitle.Text = dto.XPathTitle;
            tbXPathDate.Text = dto.XPathDate;
            tbXPathDescription.Text = dto.XPathDescription;
            tbXPathImage.Text = dto.XPathImage;
            tbXPathContent.Text = dto.XPathContent;
        }

        private void LoadLinkDTOToListView(List<LinkDTO> listDTO)
        {
            lvCrawlerLink.Clear();
            foreach (var dto in listDTO)
            {
                string[] item = { dto.ID, dto.Name, dto.IsRun.ToString() };
                lvCrawlerLink.Items.Add(new ListViewItem(item));
            }
        }

        private void LoadSubLinkDTOToListView(List<SubLinkDTO> listDTO)
        {
            lvSubLink.Clear();
            foreach (var dto in listDTO)
            {
                string[] item = { dto.ID, dto.Name, dto.IsRun.ToString() };
                lvSubLink.Items.Add(new ListViewItem(item));
            }
        }

        private void InsertOrUpdateLinkDTO(LinkDTO dto)
        {
            bool isOK = FromEvents.InsertOrUpdateLinkDTO(dto);
            if (isOK)
            {
                lbID.Text = "";
                ListLinkDTO = FromEvents.GetListLinkDTO();
                LoadLinkDTOToListView(ListLinkDTO);
            }
        }

        private void InsertOrUpdateSubLinkDTO(SubLinkDTO dto)
        {
            bool isOK = FromEvents.InsertOrUpdateSubLinkDTO(dto);
            if (isOK)
            {
                lbSubID.Text = "";
                var link = FromEvents.GetLinkDTO(dto.LinkID, ListLinkDTO);
                LoadSubLinkDTOToListView(link.ListSubLink);
            }
        }


    }
}
