using System.ComponentModel.DataAnnotations;

namespace UCSImporter.Data.Entities;

public sealed class ChartEntity
{
    [Key] public int ChartId { get; set; }

    [Required] public string SongName { get; set; }

    [Required] public DateOnly UploadDate { get; set; }

    [Required] public string StepArtistName { get; set; }

    [Required] public string ChartType { get; set; }

    [Required] public int Level { get; set; }
}