namespace System.Net.Http;

[Token(Token = "0x2000005")]
internal interface IMonoHttpClientHandler : IDisposable
{

	[Token(Token = "0x17000003")]
	public SslClientAuthenticationOptions SslOptions
	{
		[Token(Token = "0x6000011")]
		 get { } //Length: 0
		[Token(Token = "0x6000012")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000011")]
	public SslClientAuthenticationOptions get_SslOptions() { }

	[Token(Token = "0x6000013")]
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	[Token(Token = "0x6000012")]
	public void set_SslOptions(SslClientAuthenticationOptions value) { }

	[Token(Token = "0x6000014")]
	public void SetWebRequestTimeout(TimeSpan timeout) { }

}

