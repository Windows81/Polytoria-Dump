namespace System.Text.RegularExpressions;

[Token(Token = "0x20000F8")]
public abstract class RegexRunner
{
	[Token(Token = "0x4000441")]
	private const int TimeoutCheckFrequency = 1000; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000430")]
	protected private int runtextbeg; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000431")]
	protected private int runtextend; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000432")]
	protected private int runtextstart; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000433")]
	protected private string runtext; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000434")]
	protected private int runtextpos; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000435")]
	protected private Int32[] runtrack; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000436")]
	protected private int runtrackpos; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000437")]
	protected private Int32[] runstack; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000438")]
	protected private int runstackpos; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000439")]
	protected private Int32[] runcrawl; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400043A")]
	protected private int runcrawlpos; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400043B")]
	protected private int runtrackcount; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400043C")]
	protected private Match runmatch; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400043D")]
	protected private Regex runregex; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400043E")]
	private int _timeout; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400043F")]
	private bool _ignoreTimeout; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000440")]
	private int _timeoutOccursAt; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000442")]
	private int _timeoutChecksToSkip; //Field offset: 0x7C

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005ED")]
	protected private RegexRunner() { }

	[Address(RVA = "0x17762A0", Offset = "0x17754A0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegexRunner), Member = "Crawl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000600")]
	protected void Capture(int capnum, int start, int end) { }

	[Address(RVA = "0x1776330", Offset = "0x1775530", Length = "0xDB")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexRunner), Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TimeSpan)}, ReturnType = typeof(Match))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RegexMatchTimeoutException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005F0")]
	protected void CheckTimeout() { }

	[Address(RVA = "0x1776410", Offset = "0x1775610", Length = "0xE0")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexRunner), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexRunner), Member = "TransferCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60005FD")]
	protected void Crawl(int i) { }

	[Address(RVA = "0x1776500", Offset = "0x1775700", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005FF")]
	protected int Crawlpos() { }

	[Address(RVA = "0x1776520", Offset = "0x1775720", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RegexMatchTimeoutException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005F1")]
	private void DoCheckTimeout() { }

	[Address(RVA = "0x1776600", Offset = "0x1775800", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005FC")]
	protected void DoubleCrawl() { }

	[Address(RVA = "0x17766B0", Offset = "0x17758B0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005FB")]
	protected void DoubleStack() { }

	[Address(RVA = "0x1776760", Offset = "0x1775960", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005FA")]
	protected void DoubleTrack() { }

	[Address(RVA = "0x1776810", Offset = "0x1775A10", Length = "0x14D")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Backtrack", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005F7")]
	protected void EnsureStorage() { }

	[Token(Token = "0x60005F3")]
	protected abstract bool FindFirstChar() { }

	[Token(Token = "0x60005F2")]
	protected abstract void Go() { }

	[Address(RVA = "0x1776960", Offset = "0x1775B60", Length = "0x2AC")]
	[CalledBy(Type = typeof(RegexRunner), Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TimeSpan)}, ReturnType = typeof(Match))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Match), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MatchSparse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(Hashtable), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60005F5")]
	private void InitMatch() { }

	[Token(Token = "0x60005F4")]
	protected abstract void InitTrackCount() { }

	[Address(RVA = "0x1776C10", Offset = "0x1775E10", Length = "0xE9")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005F8")]
	protected bool IsBoundary(int index, int startpos, int endpos) { }

	[Address(RVA = "0x1776D00", Offset = "0x1775F00", Length = "0xE9")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegexCharClass), Member = "IsECMAWordChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005F9")]
	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	[Address(RVA = "0x1776DF0", Offset = "0x1775FF0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000603")]
	protected bool IsMatched(int cap) { }

	[Address(RVA = "0x1776E20", Offset = "0x1776020", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000604")]
	protected int MatchIndex(int cap) { }

	[Address(RVA = "0x1776E50", Offset = "0x1776050", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000605")]
	protected int MatchLength(int cap) { }

	[Address(RVA = "0x1776E80", Offset = "0x1776080", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60005FE")]
	protected int Popcrawl() { }

	[Address(RVA = "0x1776EC0", Offset = "0x17760C0", Length = "0x36D")]
	[CalledBy(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Regex), Member = "ValidateMatchTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexRunner), Member = "CheckTimeout", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexRunner), Member = "InitMatch", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexRunner), Member = "TidyMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005EE")]
	protected private Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	[Address(RVA = "0x1777230", Offset = "0x1776430", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Token(Token = "0x60005EF")]
	private void StartTimeoutWatch() { }

	[Address(RVA = "0x1777260", Offset = "0x1776460", Length = "0x63")]
	[CalledBy(Type = typeof(RegexRunner), Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TimeSpan)}, ReturnType = typeof(Match))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005F6")]
	private Match TidyMatch(bool quick) { }

	[Address(RVA = "0x17772D0", Offset = "0x17764D0", Length = "0x127")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegexRunner), Member = "Crawl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000601")]
	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	[Address(RVA = "0x1777400", Offset = "0x1776600", Length = "0x4E")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000602")]
	protected void Uncapture() { }

}

