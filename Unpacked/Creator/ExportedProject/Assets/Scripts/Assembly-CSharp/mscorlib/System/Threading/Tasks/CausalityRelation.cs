namespace System.Threading.Tasks;

[Token(Token = "0x2000285")]
internal enum CausalityRelation
{
	AssignDelegate = 0,
	Join = 1,
	Choice = 2,
	Cancel = 3,
	Error = 4,
}

