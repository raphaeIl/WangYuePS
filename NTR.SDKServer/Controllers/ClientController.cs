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
        ""nonage_time_st"": ""2025-01-03 21:00:00"",
        ""nonage_time_end"": ""2025-01-04 20:00:00"",
        ""captcha_common"": ""hidden"",
        ""download_url"": """",
        ""up_memo"": """",
        ""is_force_up"": ""hidden"",
        ""review_bundle_ver"": """",
        ""protocol_version"": """",
        ""ts"": 1735930622,
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
            ""id"": 168,
            ""version"": ""1.1.0.11"",
            ""version_content"": ""1. \u7528\u6237\u53cd\u9988\u65b0\u589e\u542f\u52a8\u5668\u65e5\u5fd7\u548cSDK\u65e5\u5fd7"",
            ""publish_time"": ""2025-01-03 22:13:33"",
            ""cdn_url"": ""https://wy-game-launcher-cdn.shiyue.com/release/launcher_update/1/1.1.0.11/"",
            ""check_file_url"": ""https://wy-game-launcher-cdn.shiyue.com/release/launcher_update/1/1.1.0.11/check_file.json"",
            ""check_file_md5"": ""e162f642af1dd5b7235426ac68404038"",
            ""zip_md5"": ""29854e7764a6f2670fa1224fc493ed10"",
            ""pre_update_num"": 0,
            ""zip_url"": ""https://wy-game-launcher-cdn.shiyue.com/release/launcher_update/1/package_package_1.1.0.11_name_WangYue2-1-release-1.1.0.11-029a5f3.zip"",
            ""zip_size"": 132315,
            ""launcher_size"": 265361,
            ""zip_name"": ""package_package_1.1.0.11_name_WangYue2-1-release-1.1.0.11-029a5f3.zip""
        },
        ""game_update"": {
            ""id"": 120,
            ""version"": ""0.39.51"",
            ""version_content"": ""svn \u8d44\u6e90\u5de5\u7a0b\u7248\u672c237329\u524d\u7aeflua\u7248\u672c237331\u7b56\u5212\u914d\u7f6e\u7248\u672c237332 \u7b56\u5212lua\u7248\u672c237335 shader\u7248\u672c234031"",
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
            ""patch"": {
                ""id"": 51,
                ""version_content"": ""\u5305\u4f53\u5de5\u7a0bclient\u7248\u672c: 237693"",
                ""cdn_url"": ""https://wy-game-launcher-cdn.shiyue.com/release/game_update/1/patch/51/"",
                ""check_file_url"": ""https://wy-game-launcher-cdn.shiyue.com/release/game_update/1/patch/51/check_file.json"",
                ""check_file_md5"": ""5fd3e428ad677b33868be2b04efc88c9"",
                ""publish_time"": ""2025-01-03 20:19:11"",
                ""zip_md5"": ""686b6bbe237ee672afa1f1c7b93b0cd8"",
                ""zip_url"": ""https://wy-game-launcher-cdn.shiyue.com/release/game_update/1/game_17676398_name_windows_out.7z"",
                ""zip_size"": 432484,
                ""pre_update_num"": 0
            }
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
    ""code"": 0,
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
        ""activation_test_status"": ""check_is_ok"",
        ""activation_test_msg"": ""\u8d26\u53f7\u767b\u5f55\u9a8c\u8bc1\u5931\u8d25\uff0c\u8bf7\u8054\u7cfb\u5ba2\u670d\u786e\u8ba4."",
        ""activation_test_no"": ""\u6d4b\u8bd5\u670d0\u53f7"",
        ""activation_test_show_watermark"": 1,
        ""activation_test_guide_qq_group"": """",
        ""extension"": ""{\""activation_test_tag_name\"":\""\""}""
    }
}
");
        }

        [Route("wy/v1.0.0/assets/AuthenticationTip-BE0Lsp1p.css")]
        public IActionResult GetAuthTipCSS()
        {
            // CSS content
            string cssContent = @"[data-v-f616e45c] .content-body{height:3.17rem!important}";
            // Set headers
            Response.Headers["Content-Type"] = "text/css";
            Response.Headers["ETag"] = "\"676f6df8-32b\"";
            Response.Headers["Expires"] = "Tue, 07 Jan 2025 12:49:28 GMT";
            Response.Headers["Last-Modified"] = "Sat, 28 Dec 2024 03:18:16 GMT";
            Response.Headers["Cache-Control"] = "max-age=345600";
            Response.Headers["X-NWS-LOG-UUID"] = "312766144472995464";
            Response.Headers["Connection"] = "keep-alive";
            Response.Headers["X-Cache-Lookup"] = "Cache Miss";

            // Return the CSS content
            return Content(cssContent);
        }

        [Route("wy/v1.0.0/user/login")]

        public IActionResult GetUserLoginHTML()
        {
            // you can type on screen with Results.Text(@" lol
            string htmlContent = @"
<!doctype html>
<html lang=""en"">
  <head>
    <meta charset=""UTF-8"" />
    <link rel=""icon"" href=""/wy/v1.0.0/favicon.ico"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>SY PC SDK</title>
    <script type=""module"" crossorigin src=""/wy/v1.0.0/assets/index-DoTuwXGr.js""></script>
    <link rel=""stylesheet"" crossorigin href=""/wy/v1.0.0/assets/index-CC6zJijL.css"">
  </head>
  <body>
    <div id=""app""></div>
  </body>
</html>
";
            // Set headers
            Response.Headers["Content-Type"] = "text/html; charset=utf-8";
            Response.Headers["ETag"] = "\"676f6df8-1d3\"";
            Response.Headers["Last-Modified"] = "Sat, 28 Dec 2024 03:18:16 GMT";
            Response.Headers["X-NWS-LOG-UUID"] = "11933844528989278561";
            Response.Headers["Connection"] = "keep-alive";
            Response.Headers["X-Cache-Lookup"] = "Cache Miss";

            // Return the HTML content
            return Content(htmlContent);
        }

        [Route("wy/v1.0.0/assets/AuthenticationTip-seZrv27h.js")]
        public IActionResult GetAuthTipJS()
        {
            // JavaScript content
            string jsContent = @"import{d,o as i,c as u,a as s,D as _,q as l,f as r,p as h,l as x,j as e,_ as f}from""./index-DoTuwXGr.js"";const o=t=>(h(""data-v-f616e45c""),t=t(),x(),t),m=o(()=>e(""div"",{class:""text-[#4C5054] text-[48px] medium-text""},""seggs"",-1)),v=o(()=>e(""div"",{class:""pt-[23px] text-[#878787] text-[24px]""},[e(""p"",null,"" 亲爱的用户您好，根据国家规定，游戏用户均需要使用真实身份完成实名认证后方可进入游戏。请您根据提示完成实名认证。 "")],-1)),C=d({__name:""AuthenticationTip"",props:{data:{default:()=>({})}},setup(t,{expose:c}){const a=l(),n=()=>{a.push({name:""login"",query:{noCheckEnv:""true""}})},p=()=>{a.push({name:""authentication""})};return i(()=>{}),c({}),(k,I)=>(r(),u(_,{handleCancel:n,handleOk:p,cancelText:""取消"",class:""!h-[430px]""},{title:s(()=>[m]),default:s(()=>[v]),_:1}))}}),S=f(C,[[""__scopeId"",""data-v-f616e45c""]]);export{S as default};";
            // Set headers
            Response.Headers["Content-Type"] = "application/javascript; charset=utf-8";
            Response.Headers["ETag"] = "W/\"676f6df8-9aa\"";
            Response.Headers["Expires"] = "Tue, 07 Jan 2025 12:49:28 GMT";
            Response.Headers["Last-Modified"] = "Sat, 28 Dec 2024 03:18:16 GMT";
            Response.Headers["Cache-Control"] = "max-age=345600";
            Response.Headers["X-NWS-LOG-UUID"] = "3006712708787903445";
            Response.Headers["Connection"] = "keep-alive";
            Response.Headers["X-Cache-Lookup"] = "Cache Miss";

            // Return the JavaScript content
            return Content(jsContent);
        }

        [Route("wy/v1.0.0/assets/Authentication-Dk5NmKx9.js")]
        public IActionResult GetAuthenticationJS()
        {
            // JavaScript content
            string jsContent = @"import{d as _,u as g,J as y,K as w,C as A,A as S,L as F,r as b,o as k,c as C,a as i,D as T,q as M,M as B,$ as D,e as L,f as z,j as t,s as l,a0 as E,t as I,z as R,w as u,O as d}from""./index-DoTuwXGr.js"";import{t as V}from""./throttle-Dasc37Bf.js"";const j=t(""div"",{class:""text-[#4C5054] text-[48px] medium-text""},""实名认证"",-1),q=t(""div"",{class:""pt-[23px] text-[#878787] text-[24px] mb-[10px]""},[t(""p"",null,""亲爱的用户您好，根据国家规定，游戏用户均需要使用真实身份""),t(""p"",null,""完成实名认证后方可进入游戏，请您根据提示完成实名认证。"")],-1),N=[""title""],O=[""src""],U={class:""text-[#F55544] text-[20px] truncate""},J={class:""mt-[4px] relative""},K=t(""div"",{class:""flex items-center absolute left-[28px] top-1/2 -translate-y-1/2 text-[30px]""},[t(""div"",{class:""w-[91px] mr-[22px] text-[#47494F] flex justify-between""},[t(""div"",null,""姓""),t(""div"",null,""名"")]),t(""div"",{class:""w-[3px] h-[31px] bg-[#AFAFAF] rounded-[2px] opacity-50""})],-1),Q={class:""mt-[10px] relative""},Z=t(""div"",{class:""flex items-center absolute left-[28px] top-1/2 -translate-y-1/2 text-[30px]""},[t(""div"",{class:""w-[91px] mr-[22px] text-[#47494F]""},""身份证""),t(""div"",{class:""w-[3px] h-[31px] bg-[#AFAFAF] rounded-[2px] opacity-50""})],-1),P=_({__name:""Authentication"",props:{data:{default:()=>({})}},setup($,{expose:x}){const m=M();B();const r=g(),c=y();w(),A();const v=S(),e=F({name:"""",identity:""""}),o=b(""""),p=V(async()=>{if(f()){r.show(""正在认证中"");try{const n=await D({card_id:e.identity,card_name:e.name});o.value="""",await v.saveAccount(),console.log(n,""认证结果""),L()}catch(n){n.message&&(o.value=n.message)}r.hide()}},1e3),f=()=>{if(!e.name){c.addErrorToast({message:""请先输入姓名""});return}if(!e.identity){c.addErrorToast({message:""请先输入身份证号码""});return}return!0},h=()=>{m.push({name:""login"",query:{noCheckEnv:""true""}})};return k(()=>{}),x({}),(n,s)=>(z(),C(T,{goBackFunc:h},{title:i(()=>[j]),footer:i(()=>[t(""div"",{class:""big-agree-btn"",onClick:s[3]||(s[3]=(...a)=>l(p)&&l(p)(...a))},""立即认证"")]),default:i(()=>[q,t(""div"",{class:R([""flex items-center h-[22px]"",o.value?""opacity-100"":""opacity-0""]),title:o.value},[t(""img"",{src:l(E),class:""w-[20px] h-[20px] mr-[2px]""},null,8,O),t(""span"",U,I(o.value),1)],10,N),t(""div"",J,[u(t(""input"",{""onUpdate:modelValue"":s[0]||(s[0]=a=>e.name=a),type:""text"",placeholder:""请输入姓名"",class:""normal-input medium-text w-full max-w-xs pl-[180px]""},null,512),[[d,e.name]]),K]),t(""div"",Q,[u(t(""input"",{""onUpdate:modelValue"":s[1]||(s[1]=a=>e.identity=a),type:""text"",onInput:s[2]||(s[2]=a=>{e.identity=a.target.value.replace(/[^a-zA-Z0-9]/g,"""").slice(0,18)}),placeholder:""请输入身份证号码"",class:""normal-input medium-text w-full max-w-xs pl-[180px]""},null,544),[[d,e.identity]]),Z])]),_:1}))}});export{P as default};";
            // Set headers
            Response.Headers["Content-Type"] = "application/javascript; charset=utf-8";
            Response.Headers["ETag"] = "W/\"676f6df8-9aa\"";
            Response.Headers["Expires"] = "Tue, 07 Jan 2025 12:49:28 GMT";
            Response.Headers["Last-Modified"] = "Sat, 28 Dec 2024 03:18:16 GMT";
            Response.Headers["Cache-Control"] = "max-age=345600";
            Response.Headers["X-NWS-LOG-UUID"] = "3006712708787903445";
            Response.Headers["Connection"] = "keep-alive";
            Response.Headers["X-Cache-Lookup"] = "Cache Miss";

            // Return the JavaScript content
            return Content(jsContent);
        }

        [Route("card/real")]
        public IResult PostCardReal()
        {
            return Results.Text(@"
{
    ""code"": 0,
    ""message"": ""\u6210\u529f"",
    ""data"": {
        ""is_real"": true,
        ""age"": 60
    }
}
");
        }

        [Route("wy/v1.0.0/user/login_success")]
        public IActionResult GetUserLoginSuccess()
        {
            string htmlContent = @"
<!doctype html>
<html lang=""en"">
  <head>
    <meta charset=""UTF-8"" />
    <link rel=""icon"" href=""/wy/v1.0.0/favicon.ico"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>SY PC SDK</title>
    <script type=""module"" crossorigin src=""/wy/v1.0.0/assets/index-DoTuwXGr.js""></script>
    <link rel=""stylesheet"" crossorigin href=""/wy/v1.0.0/assets/index-CC6zJijL.css"">
  </head>
  <body>
    <div id=""app""></div>
  </body>
</html>
";
            // Set headers
            Response.Headers["Content-Type"] = "text/html; charset=utf-8";
            Response.Headers["ETag"] = "\"676f6df8-1d3\"";
            Response.Headers["Last-Modified"] = "Sat, 28 Dec 2024 03:18:16 GMT";
            Response.Headers["X-NWS-LOG-UUID"] = "11933844528989278561";
            Response.Headers["Connection"] = "keep-alive";
            Response.Headers["X-Cache-Lookup"] = "Cache Miss";

            // Return the HTML content
            return Content(htmlContent);

        }

        [Route("wy/v1.0.0/assets/LoginSucess-TLZ3gQcw.js")]
        public IActionResult GetLoginSuccess()
        {
            string jsContent = @"import{d as n,J as i,K as c,o as r,g as p,e as u}from""./index-DoTuwXGr.js"";const l=n({__name:""LoginSucess"",props:{data:{default:()=>({})}},setup(_,{expose:a}){const e=i(),s=c(),o=async()=>{const t=await p();console.log(t,""initDatainitData""),s.hide(),e.addToast({type:t.login_type,message:t.show_name+""，欢迎进入游戏""}),setTimeout(()=>{u()},4e3)};return r(()=>{o()}),a({}),(t,d)=>null}});export{l as default};";
            Response.Headers["Content-Type"] = "application/javascript; charset=utf-8";
            Response.Headers["ETag"] = "W/\"676f6df8-9aa\"";
            Response.Headers["Expires"] = "Tue, 07 Jan 2025 12:49:28 GMT";
            Response.Headers["Last-Modified"] = "Sat, 28 Dec 2024 03:18:16 GMT";
            Response.Headers["Cache-Control"] = "max-age=345600";
            Response.Headers["X-NWS-LOG-UUID"] = "3006712708787903445";
            Response.Headers["Connection"] = "keep-alive";
            Response.Headers["X-Cache-Lookup"] = "Cache Miss";

            // Return the JavaScript content
            return Content(jsContent);
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

