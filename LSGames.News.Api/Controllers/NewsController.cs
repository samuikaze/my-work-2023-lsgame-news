using AutoMapper;
using LSGames.News.Api.Models.ServiceModels;
using LSGames.News.Api.Models.ViewModels;
using LSGames.News.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace LSGames.News.Api.Controllers
{
    [ApiController]
    [Route("news")]
    [SwaggerTag("�̷s����")]
    public class NewsController : ControllerBase
    {
        private readonly ILogger<NewsController> _logger;
        private readonly IMapper _mapper;
        private readonly INewsService _newsService;

        public NewsController(
            ILogger<NewsController> logger,
            IMapper mapper,
            INewsService newsService)
        {
            _logger = logger;
            _mapper = mapper;
            _newsService = newsService;
        }

        /// <summary>
        /// ���o�̷s����
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<GetNewsResponseViewModel> GetNewsList([FromQuery] GetNewsRequestViewModel request)
        {
            return _mapper.Map<GetNewsResponseViewModel>(
                await _newsService.GetNewsList(
                    _mapper.Map<GetNewsRequestServiceModel>(request)));
        }

        /// <summary>
        /// ���o�Ҧ��̷s��������
        /// </summary>
        /// <returns></returns>
        [HttpGet("types")]
        public async Task<List<NewsTypeViewModel>> GetNewsTypes()
        {
            return _mapper.Map<List<NewsTypeViewModel>>(
                await _newsService.GetNewsTypes());
        }

        /// <summary>
        /// �̾ڳ̷s���� PK ���o�̷s����
        /// </summary>
        /// <param name="newsId">�̷s���� PK</param>
        /// <returns></returns>
        [HttpGet("{newsId}")]
        public async Task<ActionResult<NewsViewModel>> GetNews([FromRoute] int newsId)
        {
            try
            {
                return Ok(_mapper.Map<NewsViewModel>(
                    await _newsService.GetNews(newsId)));
            }
            catch (NullReferenceException ex)
            {
                return BadRequest(
                    new ExceptionResponseViewModel()
                    {
                        Code = 400,
                        Message = ex.Message,
                        Errors = ex.GetType().Name
                    });
            }
        }

        /// <summary>
        /// �s�W����
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<int> CreateNews([FromBody] NewsViewModel request)
        {
            return await _newsService.CreateNews(
                _mapper.Map<NewsServiceModel>(request));
        }

        /// <summary>
        /// ��s����
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPatch("")]
        public async Task<int> UpdateNews([FromBody] NewsViewModel request)
        {
            return await _newsService.UpdateNews(
                _mapper.Map<NewsServiceModel>(request));
        }

        /// <summary>
        /// �R������
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete("")]
        public async Task<int> DeleteNews([FromBody] NewsViewModel request)
        {
            return await _newsService.DeleteNews(
                _mapper.Map<NewsServiceModel>(request));
        }
    }
}