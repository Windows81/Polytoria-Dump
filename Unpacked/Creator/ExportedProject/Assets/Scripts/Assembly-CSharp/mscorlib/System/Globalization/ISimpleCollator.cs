namespace System.Globalization;

[Token(Token = "0x2000563")]
internal interface ISimpleCollator
{

	[Token(Token = "0x600277A")]
	public int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	[Token(Token = "0x6002779")]
	public SortKey GetSortKey(string source, CompareOptions options) { }

	[Token(Token = "0x600277D")]
	public int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	[Token(Token = "0x600277B")]
	public bool IsPrefix(string src, string target, CompareOptions opt) { }

	[Token(Token = "0x600277C")]
	public bool IsSuffix(string src, string target, CompareOptions opt) { }

	[Token(Token = "0x600277E")]
	public int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

}

