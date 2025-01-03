using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace NTR.SDKServer.Controllers
{
    [ApiController]
    [Route("/")]
    public class LauncherSDKController : ControllerBase
    {
        private readonly ILogger<LauncherSDKController> _logger;

        public LauncherSDKController(ILogger<LauncherSDKController> logger)
        {
            _logger = logger;
        }

        [Route("exception/init")]
        public IResult PostExceptionInit()
        {
            return Results.Text(@"
{
    ""code"": 0,
    ""message"": ""success"",
    ""data"": {
        ""time_interval"": 60,
        ""cache_size"": 2048,
        ""is_allow_error_report"": 1,
        ""is_allow_crash_report"": 1,
        ""is_allow_screenshot"": 0,
        ""is_allow_oom_report"": 1,
        ""screenshot_num"": 0,
        ""screenshot_cd"": 0,
        ""oom_mem_less"": 100,
        ""is_allow_anr_report"": 1,
        ""anr_loop_timeout"": 5,
        ""sampling_rate"": 20,
        ""cos"": {
            ""bucket"": ""hitbug-1256453865"",
            ""region"": ""ap-shanghai"",
            ""startTime"": 1735898545,
            ""expiredTime"": 1735988545,
            ""sessionToken"": ""VSF4SjSGBpAC3F5IOUUpdmRg8L3n301abf9833669d5359145954c4f88b21afb3uA89E8OhmkikuBB_WPIi1cGKsZJCUYtBFU-_L2dTmZhJfG6kfaS1Lyp5iE2X--grbXtr9GQ7xoD1CJ7LfPm-tsZGd4oLiu7QA_dckBOAHZnRhQn9t8pC-Vp7igaUdtyCGcK4MRotX-_x7RGiP7fQgQWrjbfvf6T1q2tkylKRXxpr3N7DfWb8Vl4bVoV8r0Q5HhiheAocZaHDVDTjMdU47GuH_Pa0u9eAS3n4EwNnoSmSXareHPu2dwvMWQ11j-6uIGwnCRt9eYukqv5ATQ0RjY4MElIKO6JkKXLPwSFYWEe1PmFGhx0JBoW-854aSslIb253p4E6oTJnRQx7zblnkTa8nPJh9eXt82rJAp0Xw7s"",
            ""tmpSecretId"": ""AKID39MEItafXVgVovHnNAEKHjZIhAmhjjAYu3w3kalb0Lqm3Ds0AnT4hcfwgNDcou9X"",
            ""tmpSecretKey"": ""CNctfeAZWSzUswuvYeX6YjpDjPMmri7S4Mmsrg8R3Do="",
            ""session_id"": 1735898545,
            ""path"": 1735898545
        }
    }
}
");
        }

        [Route("sdk/init")]
        public IResult PostSDKInit()
        {
            return Results.Text(@"
{
    ""code"": 0,
    ""message"": ""\u6210\u529f"",
    ""data"": {
        ""pack_type"": ""general_pack"",
        ""logo"": ""display"",
        ""suspension"": ""display"",
        ""user_protocol"": ""display"",
        ""help"": ""display"",
        ""card_auth_name"": ""display"",
        ""auth_name"": ""hard"",
        ""auth_pay"": ""hard"",
        ""bind_phone"": ""hard"",
        ""adult"": ""display"",
        ""account_reg"": ""hidden"",
        ""first_page"": ""login"",
        ""wechat_auth"": ""hidden"",
        ""qq_auth"": ""hidden"",
        ""pay_warning"": ""hidden"",
        ""one_key_login"": ""hidden"",
        ""maintain"": ""hidden"",
        ""notice"": ""display"",
        ""captcha"": ""hidden"",
        ""sms_mj"": ""shiyue"",
        ""pay_sdk"": ""shiyue"",
        ""wx_mch"": ""wechat_tonglian"",
        ""zfb_mch"": ""alipay_tonglian"",
        ""qrcode_mch"": ""qrcode_tonglian"",
        ""unionpay"": ""display"",
        ""ios_pay_type"": ""IOS_STORE"",
        ""idfa_conf"": ""com"",
        ""ios_score"": ""hidden"",
        ""visitor"": ""hidden"",
        ""visitor_pay"": ""hidden"",
        ""bind_phone_new"": ""gentle"",
        ""bind_phone_gift"": ""hidden"",
        ""activation_test"": ""display"",
        ""legal_agreement"": ""hidden"",
        ""hw_account_reg"": ""hidden"",
        ""qrcode_auth_login"": ""hidden"",
        ""active_device_charge"": ""hidden"",
        ""store_kit_2"": ""hidden"",
        ""black_alert"": ""hidden"",
        ""pc_sdk_login_type"": ""account_password_login"",
        ""store_kit_2_order_num"": null,
        ""account_reg_monitor_num"": null,
        ""wechat_auth_appid"": null,
        ""bind_phone_day"": ""2"",
        ""visitor_duration"": ""60"",
        ""auth_name_duration"": ""15"",
        ""pc_sdk_web_url"": ""https://pc-sdk.shiyue.com/wy"",
        ""maintain_brief"": ""\u7ef4\u62a4\u65f6\u95f4\uff1a2019.04.03\u20142019.04.08"",
        ""notice_brief"": ""\u516c\u544a\uff1axxxx"",
        ""kf_qq_number"": ""800185843"",
        ""no_code_brief"": ""\u8bf7\u8054\u7cfb\u4f01\u4e1a\u5ba2\u670dQQ\uff1a800185843"",
        ""internal_experience"": ""hidden"",
        ""nonage_duration"": 60,
        ""nonage_time_st"": ""2025-01-02 21:00:00"",
        ""nonage_time_end"": ""2025-01-03 20:00:00"",
        ""captcha_common"": ""hidden"",
        ""download_url"": """",
        ""up_memo"": """",
        ""is_force_up"": ""hidden"",
        ""review_bundle_ver"": """",
        ""protocol_version"": """",
        ""ts"": 1735898554,
        ""agreement"": [
            {
                ""type"": ""\u9690\u79c1\u534f\u8bae"",
                ""url"": ""https://www.shiyue.com/agreement/agreementcontent_1_2_1730365518.html"",
                ""version"": 1033
            },
            {
                ""type"": ""\u7528\u6237\u534f\u8bae"",
                ""url"": ""https://www.shiyue.com/agreement/agreementcontent_1_1_1730365380.html"",
                ""version"": 1018
            }
        ],
        ""default_help_link"": ""https://kf.shiyue.com?project_id=125"",
        ""randStr"": """"
    }
}
");
        }
        //0&38&47
        // 0&39&51
        [Route("init")]
        public IResult PostInit()
        {
            return Results.Text(@"
{
    ""code"": 0,
    ""message"": ""success"",
    ""data"": {
        ""launcher_update"": {
            ""id"": 163,
            ""version"": ""1.1.0.10"",
            ""version_content"": ""1. u4feeu590du5305u540du4e2du6587u5bfcu81f4u7f13u5b58u6e05u7406u5931u8d25u7684u95eeu9898n2. u4feeu590du6e38u620fu5b89u88c5u5728u6709u7a7au683cu7684u8defu5f84u53efu80fdu5220u9664u5931u8d25u7684u95eeu9898"",
            ""publish_time"": ""2024-12-31 18:27:03"",
            ""cdn_url"": ""https://wy-game-launcher-cdn.shiyue.com/release/launcher_update/1/1.1.0.10/"",
            ""check_file_url"": ""https://wy-game-launcher-cdn.shiyue.com/release/launcher_update/1/1.1.0.10/check_file.json"",
            ""check_file_md5"": ""3eb20356d60c07c626252407d75c52da"",
            ""zip_md5"": ""3a62773eb510f0559655d08ab3b2b51a"",
            ""pre_update_num"": 0,
            ""zip_url"": ""https://wy-game-launcher-cdn.shiyue.com/release/launcher_update/1/package_package_1.1.0.10_name_WangYue2-1-release-1.1.0.10-39c450e.zip"",
            ""zip_size"": 132327,
            ""launcher_size"": 265380,
            ""zip_name"": ""package_package_1.1.0.10_name_WangYue2-1-release-1.1.0.10-39c450e.zip""
        },
        ""game_update"": {
            ""id"": 120,
            ""version"": ""0.39.51"",
            ""version_content"": ""svn u8d44u6e90u5de5u7a0bu7248u672c237329u524du7aefluau7248u672c237331u7b56u5212u914du7f6eu7248u672c237332 u7b56u5212luau7248u672c237335 shaderu7248u672c234031"",
            ""publish_time"": ""2024-12-31 20:17:34"",
            ""cdn_url"": ""https://wy-game-launcher-cdn.shiyue.com/release/game_update/1/0.39.51/"",
            ""check_file_url"": ""https://wy-game-launcher-cdn.shiyue.com/release/game_update/1/0.39.51/check_file.json"",
            ""check_file_md5"": ""65e12aee10d85d6b9d354f67eac35312"",
            ""zip_md5"": ""b01f4dcb19b20fbd39df4947440ec434"",
            ""pre_update_num"": 0,
            ""zip_url"": ""https://wy-game-launcher-cdn.shiyue.com/release/game_update/1/game_0.39.51_windows_out.zip"",
            ""zip_size"": 18390082,
            ""game_size"": 20358073,
            ""zip_name"": ""windows_out.zip"",
            ""patch"": []
        }
    }
}
");
        }

        [Route("account/login")]
        public IResult PostLogin()
        {
            return Results.Text(@"
{
    ""code"": 1,
    ""data"": {
        ""help_link"": ""https://kf.shiyue.com?project_id=125""
    },
    ""message"": ""夏萝莉是小楠梁""
}
");
        }

        [Route("sms/send")]
        public IResult PostSMSSend()
        {
            return Results.Text(@"
{
    ""code"": 0,
    ""data"": [],
    ""message"": ""成功""
}
");
        }

        [Route("account/phoneRegLogin")]
        public IResult PostPhoneRegLogin()
        {
            return Results.Text(@"
{
    ""code"": 0,
    ""message"": ""\u6210\u529f"",
    ""data"": {
        ""is_reg_login"": false,
        ""is_real"": false,
        ""is_card"": 1,
        ""age"": 0,
        ""birthday"": """",
        ""is_black_gold_user"": 0,
        ""token"": ""eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczpcL1wvc2RrLnNoaXl1ZS5jb20iLCJhdWQiOiJodHRwOlwvXC9zZGsuc2hpeXVlLm9yZyIsImp0aSI6InN5MjAxNDEyMDFnYW1lIiwiaWF0IjoxNzM1OTAwOTEwLCJleHAiOjE3MzU5MzY5MTAsIm5hbWUiOiJ0SlFXUjFTMWd1M3dhNlY3c2tnbzAiLCJkZXZfc3RyIjoiMGNkNTEzODA1YmVmMDlhYzA3Yzk1Zjc0MDY3ZGY4Y2UifQ.p460Es754YNsY1R2Mlfh3X-6EGWTKVRPwk_HzoPj0D0"",
        ""ts"": ""1735900910"",
        ""phone_number"": ""18388203810"",
        ""account_id"": ""66235699"",
        ""name"": ""18388203810"",
        ""show_name"": ""183****3810"",
        ""bind_phone"": ""gentle"",
        ""user_type"": ""5"",
        ""tick"": ""51df14d366bd96b9c7ede806a3e8924c""
    }
}
");
        }

        [Route("account/activationAccountCheck_v2")]
        public IResult PostActivationAccountCheckv2()
        {
            int[] httpStatusCodes = new int[]
            {
                // Informational responses (100–199)
                100, // Continue
                101, // Switching Protocols
                102, // Processing (WebDAV)
                103, // Early Hints

                // Successful responses (200–299)
                200, // OK
                201, // Created
                202, // Accepted
                203, // Non-Authoritative Information
                204, // No Content
                205, // Reset Content
                206, // Partial Content
                207, // Multi-Status (WebDAV)
                208, // Already Reported (WebDAV)
                226, // IM Used

                // Redirection messages (300–399)
                300, // Multiple Choices
                301, // Moved Permanently
                302, // Found
                303, // See Other
                304, // Not Modified
                305, // Use Proxy
                307, // Temporary Redirect
                308, // Permanent Redirect

                // Client error responses (400–499)
                400, // Bad Request
                401, // Unauthorized
                402, // Payment Required
                403, // Forbidden
                404, // Not Found
                405, // Method Not Allowed
                406, // Not Acceptable
                407, // Proxy Authentication Required
                408, // Request Timeout
                409, // Conflict
                410, // Gone
                411, // Length Required
                412, // Precondition Failed
                413, // Payload Too Large
                414, // URI Too Long
                415, // Unsupported Media Type
                416, // Range Not Satisfiable
                417, // Expectation Failed
                418, // I'm a teapot (RFC 2324)
                421, // Misdirected Request
                422, // Unprocessable Entity (WebDAV)
                423, // Locked (WebDAV)
                424, // Failed Dependency (WebDAV)
                425, // Too Early
                426, // Upgrade Required
                428, // Precondition Required
                429, // Too Many Requests
                431, // Request Header Fields Too Large
                451, // Unavailable For Legal Reasons

                // Server error responses (500–599)
                500, // Internal Server Error
                501, // Not Implemented
                502, // Bad Gateway
                503, // Service Unavailable
                504, // Gateway Timeout
                505, // HTTP Version Not Supported
                506, // Variant Also Negotiates
                507, // Insufficient Storage (WebDAV)
                508, // Loop Detected (WebDAV)
                510, // Not Extended
                511  // Network Authentication Required
            };
            int code = httpStatusCodes[Random.Shared.Next(0, httpStatusCodes.Length)];
            code = 0;

            return Results.Text(@"
{
    " + $"\"code\": {code}, " + @"
    ""message"": ""\u6210\u529f"",
    ""data"": {
        ""activation_test_status"": ""PC"",
        ""activation_test_msg"": ""\u8d26\u53f7\u767b\u5f55\u9a8c\u8bc1\u5931\u8d25\uff0c\u8bf7\u8054\u7cfb\u5ba2\u670d\u786e\u8ba4."",
        ""activation_test_no"": ""\u6d4b\u8bd5\u670d0\u53f7"",
        ""activation_test_show_watermark"": 1,
        ""activation_test_guide_qq_group"": """",
        ""extension"": ""{\""activation_test_tag_name\"":\""\""}""
    }
}
");
        }

        [HttpGet("{*catchAll}")]
        public IResult CatchAllGet(string catchAll)
        {
            _logger.LogDebug($"HttpGet: {catchAll}");
            return Results.Empty;
        }

        [HttpPost("{*catchAll}")]
        public IResult CatchAllPost(string catchAll)
        {
            _logger.LogDebug($"HttpGet: {catchAll}");
            return Results.Empty;
        }
    }
}

