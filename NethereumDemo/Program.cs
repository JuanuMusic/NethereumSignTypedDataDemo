// See https://aka.ms/new-console-template for more information
using Nethereum.Signer;
using Nethereum.Signer.EIP712;



var signer = new Eip712TypedDataSigner();

var key = new EthECKey("94e001d6adf3a3275d5dd45971c2a5f6637d3e9c51f9693f2e678f649e164fa5");
Console.WriteLine("Signing address: " + key.GetPublicAddress());

// Fetch the JSON data to sign.
Console.WriteLine("JSON DATA");
string json = new StreamReader("./data.json").ReadToEnd();
Console.WriteLine(json);

// SignTypedData should fign, but fails because it doesn find the Properti EIP712Domain.
// In comparison, ethers does not make that priperty mandatory.
try
{
    string signature = signer.SignTypedDataV4(json, key);
    Console.WriteLine("Signature generatd!" + signature);
}
catch (Exception ex)
{
    Console.WriteLine("An exception occurred while trying to sign the JSON data:");
    Console.WriteLine(ex.Message);
}