using prgPMR.WPF.Core.Models;

namespace prgPMR.WPF.Modules.Immunization;

public enum ImmunizationMode { Add, Edit }

/// <summary>
/// Payload passed from ImmunizationViewModel → ImmunizationDetailViewModel.
/// Replaces ImmunizationPayload from the WinForms version.
/// </summary>
public record ImmunizationNavParam(
    ImmunizationMode     Mode,
    ImmunizationSummary? Summary = null);
