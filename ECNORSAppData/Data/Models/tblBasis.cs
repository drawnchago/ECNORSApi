using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblBasis
{
    public string strServidorLocal { get; set; } = null!;

    public string strBaseLocal { get; set; } = null!;

    public string strUsuarioLocal { get; set; } = null!;

    public string strPasswordLocal { get; set; } = null!;

    public string strServidorCentral { get; set; } = null!;

    public string strBaseCentral { get; set; } = null!;

    public string strUsuarioCentral { get; set; } = null!;

    public string strPasswordCentral { get; set; } = null!;
}
