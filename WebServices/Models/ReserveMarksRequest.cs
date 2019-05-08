using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models{

    public class ReserveMarksRequest{

        public string Location { get; set; }
        public string Document { get; set; }
        public string Result { get; set; }
        public IList<ReserveMarksRequestMaterial> Materials { get; set; }
        public string Status { get; set; }
    }

    public class ReserveMarksRequestMaterial {
        public string Id { get; set; }
        public string Batch { get; set; }
    }
}