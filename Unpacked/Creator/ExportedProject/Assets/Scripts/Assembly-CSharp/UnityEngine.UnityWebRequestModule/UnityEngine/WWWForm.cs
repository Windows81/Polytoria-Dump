namespace UnityEngine;

[Token(Token = "0x2000003")]
public class WWWForm
{
	[Token(Token = "0x4000008")]
	private static Byte[] dDash; //Field offset: 0x0
	[Token(Token = "0x4000009")]
	private static Byte[] crlf; //Field offset: 0x8
	[Token(Token = "0x400000A")]
	private static Byte[] contentTypeHeader; //Field offset: 0x10
	[Token(Token = "0x400000B")]
	private static Byte[] dispositionHeader; //Field offset: 0x18
	[Token(Token = "0x400000C")]
	private static Byte[] endQuote; //Field offset: 0x20
	[Token(Token = "0x400000D")]
	private static Byte[] fileNameField; //Field offset: 0x28
	[Token(Token = "0x400000E")]
	private static Byte[] ampersand; //Field offset: 0x30
	[Token(Token = "0x400000F")]
	private static Byte[] equal; //Field offset: 0x38
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000002")]
	private List<Byte[]> formData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000003")]
	private List<String> fieldNames; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000004")]
	private List<String> fileNames; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000005")]
	private List<String> types; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000006")]
	private Byte[] boundary; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000007")]
	private bool containsFiles; //Field offset: 0x38

	[Token(Token = "0x17000003")]
	public Byte[] data
	{
		[Address(RVA = "0x1CFCB60", Offset = "0x1CFBD60", Length = "0xFA6")]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "SetupPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(WWWForm)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(WWWTranscoder), Member = "SevenBitClean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(WWWTranscoder), Member = "QPEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(WWWTranscoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte), typeof(Byte[]), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 19)]
		[Token(Token = "0x600000E")]
		 get { } //Length: 4006
	}

	[Token(Token = "0x17000001")]
	internal static Encoding DefaultEncoding
	{
		[Address(RVA = "0x1CFCB50", Offset = "0x1CFBD50", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[Token(Token = "0x6000006")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x17000002")]
	public Dictionary<String, String> headers
	{
		[Address(RVA = "0x1CFDB10", Offset = "0x1CFCD10", Length = "0x12D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000D")]
		 get { } //Length: 301
	}

	[Address(RVA = "0x1CFC630", Offset = "0x1CFB830", Length = "0x350")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x600000F")]
	private static WWWForm() { }

	[Address(RVA = "0x1CFC990", Offset = "0x1CFBB90", Length = "0x1B4")]
	[CalledBy(Type = "Polytoria.Controllers.ScreenshotController+<DoPublishScreenshot>d__27", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<PublishLevelToID>d__81", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<DoPublishModel>d__62", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.AbuseReportController+<SubmitAbuseReport>d__6", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.DataStoreService+<DoWriteToServer>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.AchievementService+<DoAward>d__11", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Player+<LoadMetadata>d__205", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Networking.PTAuthenticator+<ValidateToken>d__5", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "PurchasesService+<DoProcessPurchase>d__18", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ChatService+<LogChatMessage>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6000007")]
	public WWWForm() { }

	[Address(RVA = "0x1CFBFB0", Offset = "0x1CFB1B0", Length = "0x1A")]
	[CalledBy(Type = "Polytoria.Controllers.ScreenshotController+<DoPublishScreenshot>d__27", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WWWForm), Member = "AddBinaryData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x600000B")]
	public void AddBinaryData(string fieldName, Byte[] contents, string fileName) { }

	[Address(RVA = "0x1CFBFD0", Offset = "0x1CFB1D0", Length = "0x323")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<PublishLevelToID>d__81", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WWWForm), Member = "AddBinaryData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000C")]
	public void AddBinaryData(string fieldName, Byte[] contents, string fileName, string mimeType) { }

	[Address(RVA = "0x1CFC580", Offset = "0x1CFB780", Length = "0x49")]
	[CalledBy(Type = "PurchasesService+<DoProcessPurchase>d__18", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Networking.PTAuthenticator+<ValidateToken>d__5", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Player+<LoadMetadata>d__205", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ChatService+<LogChatMessage>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.DataStoreService+<DoWriteToServer>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.AbuseReportController+<SubmitAbuseReport>d__6", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ScreenshotController+<DoPublishScreenshot>d__27", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<DoPublishModel>d__62", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<PublishLevelToID>d__81", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(WWWForm), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Encoding)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000008")]
	public void AddField(string fieldName, string value) { }

	[Address(RVA = "0x1CFC300", Offset = "0x1CFB500", Length = "0x27F")]
	[CalledBy(Type = typeof(WWWForm), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WWWForm), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000009")]
	public void AddField(string fieldName, string value, Encoding e) { }

	[Address(RVA = "0x1CFC5D0", Offset = "0x1CFB7D0", Length = "0x5A")]
	[CalledBy(Type = "PurchasesService+<DoProcessPurchase>d__18", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.AchievementService+<DoAward>d__11", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ChatService+<LogChatMessage>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<DoPublishModel>d__62", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<PublishLevelToID>d__81", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(WWWForm), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Encoding)}, ReturnType = typeof(void))]
	[Token(Token = "0x600000A")]
	public void AddField(string fieldName, int i) { }

	[Address(RVA = "0x1CFCB60", Offset = "0x1CFBD60", Length = "0xFA6")]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "SetupPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(WWWForm)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WWWTranscoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte), typeof(Byte[]), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(WWWTranscoder), Member = "QPEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(WWWTranscoder), Member = "SevenBitClean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 19)]
	[Token(Token = "0x600000E")]
	public Byte[] get_data() { }

	[Address(RVA = "0x1CFCB50", Offset = "0x1CFBD50", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Token(Token = "0x6000006")]
	internal static Encoding get_DefaultEncoding() { }

	[Address(RVA = "0x1CFDB10", Offset = "0x1CFCD10", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000D")]
	public Dictionary<String, String> get_headers() { }

}

