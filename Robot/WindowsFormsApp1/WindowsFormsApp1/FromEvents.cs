using Crawler.Database.Models;
using Crawler.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class FromEvents
    {
        public static List<LinkDTO> GetListLinkDTO()
        {
            List<LinkDTO> listResult = new List<LinkDTO>();
            try
            {
                using (var _db = new CrawlerModel())
                {
                    listResult = _db.CrawlerLinks.Where(o => !o.IsDelete).Select(o => new LinkDTO()
                    {
                        ID = o.ID,
                        Name = o.Name,
                        Link = o.Link,
                        IsRun = o.IsRun
                    }).ToList();

                    var listLinkID = listResult.Select(o => o.ID).ToList();
                    var listSubLink = _db.CrawlerSubLinks.Where(o => listLinkID.Contains(o.CrawlerLinkID) && !o.IsDelete).Select(o => new SubLinkDTO()
                    {
                        ID = o.ID,
                        LinkID = o.CrawlerLinkID,
                        Name = o.Name,
                        SubLink = o.SubLink,
                        IsRun = o.IsRun,
                        XPathTitle = o.XPathTitle,
                        XPathImage = o.XPathImage,
                        XPathDate = o.XPathDate,
                        XPathDescription = o.XPathDescription,
                        XPathContent = o.XPathContent
                    }).ToList();

                    foreach (var item in listResult)
                    {
                        item.ListSubLink = new List<SubLinkDTO>();
                        item.ListSubLink = listSubLink.Where(o => o.LinkID == item.ID).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listResult;
        }

        public static LinkDTO GetLinkDTO(string id, List<LinkDTO> listDTO)
        {
            return listDTO.Where(o => o.ID == id).FirstOrDefault();
        }

        public static SubLinkDTO GetSubLinkDTO(string id, List<SubLinkDTO> listSubDTO)
        {
            return listSubDTO.Where(o => o.ID == id).FirstOrDefault();
        }

        public static bool InsertOrUpdateLinkDTO(LinkDTO dto)
        {
            bool result = false;
            try
            {
                using (var _db = new CrawlerModel())
                {
                    if (string.IsNullOrEmpty(dto.ID))
                    {
                        CrawlerLink link = new CrawlerLink()
                        {
                            ID = Guid.NewGuid().ToString(),
                            Name = dto.Name,
                            Link = dto.Link,
                            IsRun = dto.IsRun,
                            IsDelete = false,
                            CreateUser = "admin",
                            CreateDate = DateTime.Now,
                            ModifierUser = "admin",
                            ModifierDate = DateTime.Now
                        };
                        _db.CrawlerLinks.Add(link);
                    }
                    else
                    {
                        var link = _db.CrawlerLinks.Where(o => o.ID == dto.ID).FirstOrDefault();
                        if (link != null)
                        {
                            link.Name = dto.Name;
                            link.Link = dto.Link;
                            link.IsRun = dto.IsRun;
                            link.ModifierDate = DateTime.Now;
                        }
                    }
                    if (_db.SaveChanges() > 0)
                        result = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public static bool InsertOrUpdateSubLinkDTO(SubLinkDTO dto)
        {
            bool result = false;
            try
            {
                using (var _db = new CrawlerModel())
                {
                    if (string.IsNullOrEmpty(dto.ID))
                    {
                        CrawlerSubLink subLink = new CrawlerSubLink()
                        {
                            ID = Guid.NewGuid().ToString(),
                            CrawlerLinkID = dto.LinkID,
                            Name = dto.Name,
                            SubLink = dto.SubLink,
                            IsRun = dto.IsRun,
                            XPathTitle = dto.XPathTitle,
                            XPathDate = dto.XPathDate,
                            XPathImage = dto.XPathImage,
                            XPathDescription = dto.XPathDescription,
                            XPathContent = dto.XPathContent,
                            IsDelete = false,
                            CreateUser = "admin",
                            CreateDate = DateTime.Now,
                            ModifierUser = "admin",
                            ModifierDate = DateTime.Now
                        };
                        _db.CrawlerSubLinks.Add(subLink);
                    }
                    else
                    {
                        var subLink = _db.CrawlerSubLinks.Where(o => o.ID == dto.ID).FirstOrDefault();
                        if (subLink != null)
                        {
                            subLink.Name = dto.Name;
                            subLink.SubLink = dto.SubLink;
                            subLink.IsRun = dto.IsRun;
                            subLink.XPathTitle = dto.XPathTitle;
                            subLink.XPathDate = dto.XPathDate;
                            subLink.XPathImage = dto.XPathImage;
                            subLink.XPathDescription = dto.XPathDescription;
                            subLink.XPathContent = dto.XPathContent;
                            subLink.ModifierDate = DateTime.Now;
                        }
                    }
                    if (_db.SaveChanges() > 0)
                        result = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public static bool DeleteLinkDTO(string id)
        {
            var result = false;
            try
            {
                using (var _db = new CrawlerModel())
                {
                    var link = _db.CrawlerLinks.Where(o => o.ID == id).FirstOrDefault();
                    if (link != null)
                    {
                        link.IsDelete = true;
                        link.ModifierDate = DateTime.Now;
                        if (_db.SaveChanges() > 0)
                            result = true;
                    }
                    else
                        result = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public static bool DeleteSubLinkDTO(string id)
        {
            var result = false;
            try
            {
                using (var _db = new CrawlerModel())
                {
                    var subLink = _db.CrawlerSubLinks.Where(o => o.ID == id).FirstOrDefault();
                    if (subLink != null)
                    {
                        subLink.IsDelete = true;
                        subLink.ModifierDate = DateTime.Now;
                        if (_db.SaveChanges() > 0)
                            result = true;
                    }
                    else
                        result = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}
