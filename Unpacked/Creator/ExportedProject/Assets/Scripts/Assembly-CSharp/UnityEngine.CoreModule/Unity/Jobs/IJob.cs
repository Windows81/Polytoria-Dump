namespace Unity.Jobs;

[JobProducerType(typeof(JobStruct`1))]
[Token(Token = "0x2000009")]
public interface IJob
{

	[Token(Token = "0x6000009")]
	public void Execute() { }

}

