﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDAL _blogDAL;

        public BlogManager(IBlogDAL blogDAL)
        {
            _blogDAL = blogDAL;
        }

        public void BlogAdd(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogDelete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogUpdate(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDAL.GetListWithCategory();
        }

        public Blog GetByID(int id)
        {
            throw new NotImplementedException();
        }
       public List<Blog> GetBlogByID(int id)    
        {
            return _blogDAL.GetListAll(x => x.BlogID == id);
        
        }
        public List<Blog> GetListBlog()
        {
            return _blogDAL.ListAll();
        }

        public List<Blog> GetBlogListByBlog(int id)
        {
            return _blogDAL.GetListAll(x => x.WriterID == id);
        }
    }
}
