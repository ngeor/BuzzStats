using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using BuzzStats.WebApi.DTOs;
using BuzzStats.WebApi.Storage.Entities;
using log4net;
using NHibernate;
using NHibernate.Criterion;

namespace BuzzStats.WebApi.Storage
{
    public class CommentController : ApiController
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(CommentController));
        private readonly ISessionFactory _sessionFactory;
        private readonly IMapper _mapper;

        public CommentController(ISessionFactory sessionFactory, IMapper mapper)
        {
            _sessionFactory = sessionFactory;
            _mapper = mapper;
        }
        
        // GET api/comment
        public IEnumerable<CommentWithStory> Get()
        {
            try
            {
                using (var session = _sessionFactory.OpenSession())
                {
                    var criteria = session.CreateCriteria<CommentEntity>();
                    criteria = criteria.SetMaxResults(20);
                    criteria = criteria.AddOrder(Order.Desc("CreatedAt"));
                    return criteria.List<CommentEntity>().Select(c => _mapper.Map<CommentWithStory>(c)).ToList();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}