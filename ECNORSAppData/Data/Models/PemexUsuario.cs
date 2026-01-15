using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class PemexUsuario
{
    public string Username { get; set; } = null!;

    public string? Password { get; set; }

    public string? Email { get; set; }

    public bool? EnviarCorreo { get; set; }
}
