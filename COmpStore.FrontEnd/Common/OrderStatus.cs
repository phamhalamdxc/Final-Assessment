using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace COmpStore.FrontEnd
{
    public enum OrderStatus
    {
        //[Display(Name = "Chưa xử lí")]
        NotProcessYet,
        //[Display(Name = "Đang xử lí")]
        Processing,
        //[Display(Name = "Đã hoàn tất")]
        Processed,
        //[Display(Name = "Đã từ chối")]
        Denied
    }
}
