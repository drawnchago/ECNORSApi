using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblBackupSchedule
{
    public int intID { get; set; }

    public string? strHost { get; set; }

    public string? strUser { get; set; }

    public byte[]? strPass { get; set; }

    public string? strDB { get; set; }

    public string? strPath { get; set; }

    public int? intStatus { get; set; }

    public string? created_by { get; set; }

    public DateTime? created_at { get; set; }

    public DateTime? updated_at { get; set; }

    public string? strDescription { get; set; }

    /// <summary>
    /// fecha de inicio del backup
    /// </summary>
    public DateTime? datStartDate { get; set; }

    /// <summary>
    /// si tiene fin de operación 
    /// </summary>
    public DateTime? datEndDate { get; set; }

    /// <summary>
    /// intervalo entre cada iteración 
    /// </summary>
    public int? intInterval { get; set; }

    /// <summary>
    /// L,M,M,J,V,S,D
    /// </summary>
    public string? strWeeksday { get; set; }

    /// <summary>
    /// 1=OneTime|2=Daily|3=Weekly|4=Monthly
    /// </summary>
    public string? strScheduleType { get; set; }
}
