using System;

namespace Model
{
    public class log {
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
    }
}
