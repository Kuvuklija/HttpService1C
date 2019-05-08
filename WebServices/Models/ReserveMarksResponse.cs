using System.Collections.Generic;

namespace WebServices.Models{

    public class ReserveMarksResponse{

        public string Location { get; set; }
        public string Document { get; set; }
        public string Result { get; set; }
        //public IList<ReserveMarksResponseMaterial> Materials { get; set; }
        public string Id { get; set; }
        public string Batch { get; set; }
        public string DocumentRow { get; set; }
        public string PalletBarcode { get; set; }
        public string CartonBarcode { get; set; }
        public string Code { get; set; }
        public string Status { get; set; }
    }

    //public class ReserveMarksResponseMaterial {
    //    public string Id { get; set; }
    //    public string Batch { get; set; }
    //    public string DocumentRow { get; set; }
    //    public IList<ReserveMarksResponsePallet> Pallets { get; set; }
    //}

    //public class ReserveMarksResponsePallet {
    //    public string Barcode { get; set; }
    //    public IList<ReserveMarksResponseCarton> Cartons { get; set; }
    //}

    //public class ReserveMarksResponseCarton {
    //    public string Barcode { get; set; }
    //    public IList<ReserveMarksResponseMark> Marks { get; set; }
    //}

    //public class ReserveMarksResponseMark {
    //    public string Code { get; set; }
    //}
}