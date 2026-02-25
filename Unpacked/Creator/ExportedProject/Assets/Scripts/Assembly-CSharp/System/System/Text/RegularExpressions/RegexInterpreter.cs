namespace System.Text.RegularExpressions;

[Token(Token = "0x20000F1")]
internal sealed class RegexInterpreter : RegexRunner
{
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40003F5")]
	private readonly RegexCode _code; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40003F6")]
	private readonly CultureInfo _culture; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40003F7")]
	private int _operator; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40003F8")]
	private int _codepos; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40003F9")]
	private bool _rightToLeft; //Field offset: 0x98
	[FieldOffset(Offset = "0x99")]
	[Token(Token = "0x40003FA")]
	private bool _caseInsensitive; //Field offset: 0x99

	[Address(RVA = "0x176CF10", Offset = "0x176C110", Length = "0x5A")]
	[CalledBy(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000554")]
	public RegexInterpreter(RegexCode code, CultureInfo culture) { }

	[Address(RVA = "0x1769CF0", Offset = "0x1768EF0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000556")]
	private void Advance(int i) { }

	[Address(RVA = "0x1769D70", Offset = "0x1768F70", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegexRunner), Member = "EnsureStorage", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000563")]
	private void Backtrack() { }

	[Address(RVA = "0x1769E50", Offset = "0x1769050", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000578")]
	private void Backwardnext() { }

	[Address(RVA = "0x1769E70", Offset = "0x1769070", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000573")]
	private int Bump() { }

	[Address(RVA = "0x1769E90", Offset = "0x1769090", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000579")]
	private char CharAt(int j) { }

	[Address(RVA = "0x1769EB0", Offset = "0x17690B0", Length = "0x456")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegexCharClass), Member = "IsSingleton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexInterpreter), Member = "Forwardcharnext", ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "SingletonChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexBoyerMoore), Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexBoyerMoore), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600057A")]
	protected virtual bool FindFirstChar() { }

	[Address(RVA = "0x176A310", Offset = "0x1769510", Length = "0x92")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "FindFirstChar", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000575")]
	private char Forwardcharnext() { }

	[Address(RVA = "0x176A3B0", Offset = "0x17695B0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000574")]
	private int Forwardchars() { }

	[Address(RVA = "0x176A3D0", Offset = "0x17695D0", Length = "0x2070")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegexInterpreter), Member = "TrackPush2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(RegexRunner), Member = "EnsureStorage", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexRunner), Member = "Uncapture", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexInterpreter), Member = "Operand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexInterpreter), Member = "TrackPush2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexRunner), Member = "IsECMABoundary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180187840")]
	[Calls(Type = typeof(RegexRunner), Member = "Crawl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexInterpreter), Member = "StackPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexInterpreter), Member = "TrackPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(RegexRunner), Member = "IsBoundary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RegexInterpreter), Member = "Refmatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexInterpreter), Member = "Stringmatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexInterpreter), Member = "TrackPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegexInterpreter), Member = "Forwardcharnext", ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexRunner), Member = "CheckTimeout", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexInterpreter), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NotImplemented), Member = "ByDesignWithMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600057B")]
	protected virtual void Go() { }

	[Address(RVA = "0x176C590", Offset = "0x176B790", Length = "0x80")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RegexRunner), Member = "EnsureStorage", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000557")]
	private void Goto(int newpos) { }

	[Address(RVA = "0x176C620", Offset = "0x176B820", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000555")]
	protected virtual void InitTrackCount() { }

	[Address(RVA = "0x176C650", Offset = "0x176B850", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000571")]
	private int Leftchars() { }

	[Address(RVA = "0x176C660", Offset = "0x176B860", Length = "0x41")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000570")]
	private int Operand(int i) { }

	[Address(RVA = "0x2FDE20", Offset = "0x2FD020", Length = "0x7")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600056F")]
	private int Operator() { }

	[Address(RVA = "0x176C6B0", Offset = "0x176B8B0", Length = "0x1C8")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000577")]
	private bool Refmatch(int index, int len) { }

	[Address(RVA = "0x176C880", Offset = "0x176BA80", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000572")]
	private int Rightchars() { }

	[Address(RVA = "0x176C890", Offset = "0x176BA90", Length = "0x28")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000564")]
	private void SetOperator(int op) { }

	[Address(RVA = "0x176C8F0", Offset = "0x176BAF0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600056E")]
	private int StackPeek(int i) { }

	[Address(RVA = "0x176C8C0", Offset = "0x176BAC0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600056D")]
	private int StackPeek() { }

	[Address(RVA = "0x176C930", Offset = "0x176BB30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600056B")]
	private void StackPop() { }

	[Address(RVA = "0x176C940", Offset = "0x176BB40", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600056C")]
	private void StackPop(int framesize) { }

	[Address(RVA = "0x176C9B0", Offset = "0x176BBB0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000569")]
	private void StackPush(int I1) { }

	[Address(RVA = "0x176C950", Offset = "0x176BB50", Length = "0x5B")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600056A")]
	private void StackPush(int I1, int I2) { }

	[Address(RVA = "0x176C9F0", Offset = "0x176BBF0", Length = "0x15C")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000576")]
	private bool Stringmatch(string str) { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600055B")]
	private int Textpos() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600055A")]
	private int Textstart() { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000558")]
	private void Textto(int newpos) { }

	[Address(RVA = "0x176CB90", Offset = "0x176BD90", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000567")]
	private int TrackPeek() { }

	[Address(RVA = "0x176CB50", Offset = "0x176BD50", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000568")]
	private int TrackPeek(int i) { }

	[Address(RVA = "0x176CBD0", Offset = "0x176BDD0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000566")]
	private void TrackPop(int framesize) { }

	[Address(RVA = "0x176CBC0", Offset = "0x176BDC0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000565")]
	private void TrackPop() { }

	[Address(RVA = "0x176CED0", Offset = "0x176C0D0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600055C")]
	private int Trackpos() { }

	[Address(RVA = "0x176CCE0", Offset = "0x176BEE0", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000560")]
	private void TrackPush(int I1, int I2, int I3) { }

	[Address(RVA = "0x176CD90", Offset = "0x176BF90", Length = "0x85")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600055F")]
	private void TrackPush(int I1, int I2) { }

	[Address(RVA = "0x176CE90", Offset = "0x176C090", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600055D")]
	private void TrackPush() { }

	[Address(RVA = "0x176CE20", Offset = "0x176C020", Length = "0x60")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600055E")]
	private void TrackPush(int I1) { }

	[Address(RVA = "0x176CBE0", Offset = "0x176BDE0", Length = "0x87")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000562")]
	private void TrackPush2(int I1, int I2) { }

	[Address(RVA = "0x176CC70", Offset = "0x176BE70", Length = "0x60")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000561")]
	private void TrackPush2(int I1) { }

	[Address(RVA = "0x176CEF0", Offset = "0x176C0F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000559")]
	private void Trackto(int newpos) { }

}

