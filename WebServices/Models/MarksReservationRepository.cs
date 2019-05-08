using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models{

    public class MarksReservationRepository{

        private static MarksReservationRepository repo = new MarksReservationRepository();

        public static MarksReservationRepository CurrentRepository { get { return repo; } }

        private List<ReserveMarksResponse> context = new List<ReserveMarksResponse> {
            new ReserveMarksResponse {Location="Москва, Россия", Document="190321-РАШР0003555", Id="49.097.01.08.16",
                Batch ="000227599",DocumentRow="1", PalletBarcode="001",CartonBarcode="111",Result="Ok", Status="Reserved" },
            new ReserveMarksResponse {Location="Москва, Россия", Document="190321-РАШР0003555", Id="96.551.01.07.49",
                Batch ="000213884",DocumentRow="2", PalletBarcode="002",CartonBarcode="222",Result="Ok", Status="Reserved" },
            new ReserveMarksResponse {Location="Москва, Россия", Document="190321-РАШР0003555", Id="49.097.01.08.16",
                Batch ="000221233",DocumentRow="3", PalletBarcode="003",CartonBarcode="333",Result="Ok", Status="Reserved"},
            new ReserveMarksResponse {Location="Москва, Россия", Document="190321-РАШР0003555", Id="49.097.01.08.16",
                Batch ="000227555",DocumentRow="4", PalletBarcode="004",CartonBarcode="444",Result="Ok",Status="Reserved" },
            new ReserveMarksResponse {Location="Москва, Россия", Document="190321-РАШР0003555", Id="49.097.01.08.16",
                Batch ="000227556",DocumentRow="5", PalletBarcode="001",CartonBarcode="111",Result="Ok", Status="Reserved" },
            new ReserveMarksResponse {Location="Москва, Россия", Document="190321-РАШР0003555", Id="49.097.01.08.16",
                Batch ="000227599",DocumentRow="6", PalletBarcode="001",CartonBarcode="111",Result="Ok",Status="STOCK" },
            new ReserveMarksResponse {Location="Москва, Россия", Document="190321-РАШР0003555", Id="49.097.01.08.16",
                Batch ="000227500",DocumentRow="7", PalletBarcode="001",CartonBarcode="111",Result="Ok" },
            new ReserveMarksResponse {Location="Москва, Россия", Document="190321-РАШР0003555", Id="49.097.01.08.16",
                Batch ="000227501",DocumentRow="8", PalletBarcode="001",CartonBarcode="111",Result="Ok" }
        };

        public IEnumerable<ReserveMarksResponse> GetAll() {
            return context;
        }

        public IEnumerable<ReserveMarksResponse> Get(string location, string document, IEnumerable<string> id, IEnumerable<string> batch) {
            return context
                .Where(x => x.Location == location && x.Document == document && x.Id.Any(t => id.Contains(t.ToString())));// && x.Batch.Any(t=>batch.Contains(t.ToString())));
        }
    }
}