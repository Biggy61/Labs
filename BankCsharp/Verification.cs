namespace Bank;

public class Verification
{
    public string Verifier { get; set; }
    private DateTime VerificationDate { get; set; }
    public VerificationResults VerificationResult { get; set; }
    public string FurtherInfo  { get; set; }

    public Verification(string verifier, DateTime verificationDate, VerificationResults VerificationResult, string furtherInfo)
    {
        Verifier = verifier;
        VerificationDate = verificationDate;
        VerificationResult = VerificationResult;
        if(VerificationResult is VerificationResults.Denied or VerificationResults.FurtherVerificationNeeded)
        {
            FurtherInfo = furtherInfo;
        }
        else { FurtherInfo = "No further info"; }
    }

    public enum VerificationResults
    {
        Unknown,
        Verified,
        Denied,
        FurtherVerificationNeeded
    }
}