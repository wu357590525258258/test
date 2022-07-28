using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace test.Controllers
{
    /// <summary>
    /// 订单接口
    /// </summary>
    [ApiController]
    [Route("[controller]/[action]")]
    [ApiExplorerSettings(GroupName = nameof(ApiVersionInfo.V1))]
    public class OrderController : Controller
    {
        /// <summary>
        /// 获取订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetOrder()
        {
            return "ok";
        }
        /// <summary>
        /// 创建订单
        /// </summary>
        /// <param name="request">订单信息</param>
        /// <returns></returns>
        [HttpPost]
        public string CreateOrder([FromBody] OrderRequest request)
        {
            return "ok";
        }
        /// <summary>
        /// 删除订单
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public string DeleteOrder()
        {
            return "ok";
        }
        /// <summary>
        /// 更新订单
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public string UpdateOrder()
        {
            return "ok";
        }
    }
    /// <summary>
    /// 订单请求
    /// </summary>
    public class OrderRequest
    {
        /// <summary>
        /// 订单名称
        /// </summary>
        public string? orderName { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string? orderNo { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal price { get; set; }
    }
    /// <summary>
    /// api版本号
    /// </summary>
    public class ApiVersionInfo
    {
        /// <summary>
        /// 版本号
        /// </summary>
        public static string? V1;
        /// <summary>
        /// 版本号
        /// </summary>
        public static string? V2;
        /// <summary>
        /// 版本号
        /// </summary>
        public static string? V3;
        /// <summary>
        /// 版本号
        /// </summary>
        public static string? V4;
        /// <summary>
        /// 版本号
        /// </summary>
        public static string? V5;
    }
}