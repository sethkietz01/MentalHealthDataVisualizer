using MentalHealthDataVisualizer.Models;
public class DataService
{
    public List<DemographicSummary> GetDemographicSummaries(List<AmiPrevalence> data)
    {
        return data
            .GroupBy(d => d.demographic)
            .Select(g => new DemographicSummary
            {
                Demographic = g.Key ?? "Unknown",
                TotalTally = g.Sum(d => d.tally)
            })
            .ToList();
    }

    public List<AgeCategorySummary> GetAgeCategorySummaries(List<AmiPrevalence> data)
    {
        return data
            .Where(d => !string.IsNullOrEmpty(d.age_category))
            .GroupBy(d => d.age_category)
            .Select(g => new AgeCategorySummary
            {
                AgeCategory = g.Key,
                TotalTally = g.Sum(d => d.tally)
            })
            .OrderBy(r => r.AgeCategory)
            .ToList();
    }
}

public class DemographicSummary
{
    public string Demographic { get; set; }
    public int TotalTally { get; set; }
}

public class AgeCategorySummary
{
    public string AgeCategory { get; set; }
    public int TotalTally { get; set; }
}