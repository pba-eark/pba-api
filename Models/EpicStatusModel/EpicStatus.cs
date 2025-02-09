﻿using pba_api.Models.EpicModel;

namespace pba_api.Models.EpicStatusModel
{
    public class EpicStatus
    {
        public int Id { get; set; }
        public bool Global { get; set; }
        public bool Default { get; set; }
        public string EpicStatusName { get; set; }

        public virtual ICollection<Epic> Epics { get; set; }
    }
}
