namespace Tyuiu.MuliavinIM.Sprint7.Project.V14.Lib
{
    public class TransportRoute_MIM
    {
        public string TransportType_MIM { get; set; } = string.Empty;
        public string RouteNumber_MIM { get; set; } = string.Empty;
        public DateTime StartDate_MIM { get; set; }
        public string StartStop_MIM { get; set; } = string.Empty;
        public string EndStop_MIM { get; set; } = string.Empty;
        public int TravelTimeMinutes_MIM { get; set; }
        public string Note_MIM { get; set; } = string.Empty;
    }

    public class DataService_MIM
    {
        // ===== CSV =====
        public List<TransportRoute_MIM> LoadFromCsv(string path)
        {
            var result = new List<TransportRoute_MIM>();
            if (!File.Exists(path)) return result;

            foreach (var line in File.ReadAllLines(path))
            {
                var parts = line.Split(';');
                if (parts.Length < 7) continue;

                result.Add(new TransportRoute_MIM
                {
                    TransportType_MIM = parts[0],
                    RouteNumber_MIM = parts[1],
                    StartDate_MIM = DateTime.Parse(parts[2]),
                    StartStop_MIM = parts[3],
                    EndStop_MIM = parts[4],
                    TravelTimeMinutes_MIM = int.Parse(parts[5]),
                    Note_MIM = parts[6]
                });
            }

            return result;
        }

        public void SaveToCsv(string path, List<TransportRoute_MIM> data)
        {
            var lines = data.Select(r => string.Join(";",
                r.TransportType_MIM,
                r.RouteNumber_MIM,
                r.StartDate_MIM.ToString("yyyy-MM-dd"),
                r.StartStop_MIM,
                r.EndStop_MIM,
                r.TravelTimeMinutes_MIM,
                r.Note_MIM));

            File.WriteAllLines(path, lines);
        }

        // ===== CRUD =====
        public void AddRoute(List<TransportRoute_MIM> data, TransportRoute_MIM route)
        {
            data.Add(route);
        }

        public void EditRoute(List<TransportRoute_MIM> data, int index, TransportRoute_MIM route)
        {
            if (index >= 0 && index < data.Count)
                data[index] = route;
        }

        public void DeleteRoute(List<TransportRoute_MIM> data, int index)
        {
            if (index >= 0 && index < data.Count)
                data.RemoveAt(index);
        }

        // ===== SEARCH =====
        public List<TransportRoute_MIM> SearchByRouteNumber(
            List<TransportRoute_MIM> data,
            string routeNumber)
        {
            return data
                .Where(r => r.RouteNumber_MIM.Contains(routeNumber))
                .ToList();
        }

        // ===== FILTER =====
        public List<TransportRoute_MIM> FilterByTransportType(
            List<TransportRoute_MIM> data,
            string transportType)
        {
            return data
                .Where(r => r.TransportType_MIM == transportType)
                .ToList();
        }

        // ===== SORT =====
        public List<TransportRoute_MIM> SortByTravelTime(
            List<TransportRoute_MIM> data,
            bool ascending = true)
        {
            return ascending
                ? data.OrderBy(r => r.TravelTimeMinutes_MIM).ToList()
                : data.OrderByDescending(r => r.TravelTimeMinutes_MIM).ToList();
        }

        // ===== STATISTICS =====
        public int GetCount(List<TransportRoute_MIM> data) => data.Count;
        public int GetSumTime(List<TransportRoute_MIM> data) => data.Sum(r => r.TravelTimeMinutes_MIM);
        public double GetAverageTime(List<TransportRoute_MIM> data) => data.Average(r => r.TravelTimeMinutes_MIM);
        public int GetMinTime(List<TransportRoute_MIM> data) => data.Min(r => r.TravelTimeMinutes_MIM);
        public int GetMaxTime(List<TransportRoute_MIM> data) => data.Max(r => r.TravelTimeMinutes_MIM);
    }
}
