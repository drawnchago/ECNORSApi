using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTransaccionesBancaria
{
    public string ApprovalCode { get; set; } = null!;

    public string? Account { get; set; }

    public string? Afiliado { get; set; }

    public string? AID { get; set; }

    public string? ALabel { get; set; }

    public decimal? Amount { get; set; }

    public string? APN { get; set; }

    public string? ARQC { get; set; }

    public string Autoriz { get; set; } = null!;

    public string? BankName { get; set; }

    public string? BanorteReference { get; set; }

    public string? BrandName { get; set; }

    public string? CardExpiration { get; set; }

    public string? CardHolderName { get; set; }

    public string? CardName { get; set; }

    public string? CardTypeName { get; set; }

    public string? ControlNumber { get; set; }

    public string? ErrorMessage { get; set; }

    public string? MaskedAccount { get; set; }

    public string? MerchantID { get; set; }

    public bool? PaymentOK { get; set; }

    public bool? PinRequested { get; set; }

    public string? ResponseCode { get; set; }

    public string? ResponseMessage { get; set; }

    public decimal? Saldo { get; set; }

    public string? SmartReference { get; set; }

    public string? Tarjeta { get; set; }

    public string? Terminal { get; set; }

    public string? TerminalID { get; set; }

    public string? TerminalSerialNumber { get; set; }

    public decimal? Tip { get; set; }

    public string? TipoTarjeta { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? Transaccion { get; set; }

    public string? TransaccionOrigen { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? TSI { get; set; }

    public string? TVR { get; set; }
}
