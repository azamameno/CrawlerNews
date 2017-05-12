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
            gbSubLink.Enabled = false;
            ListLinkDTO = FromEvents.GetListLinkDTO();
            LoadLinkDTOToListView(ListLinkDTO);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LinkDTO dto = new LinkDTO()
            {
                Name = tbName.Text,
                Link = tbURL.Text,
                IsRun = cbRun.Checked
            };
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

        }
    }
}
