namespace GLTFast;

[Token(Token = "0x200001E")]
public class GltfImport : GltfImportBase<Root>
{
	[Token(Token = "0x400007C")]
	private static GltfJsonUtilityParser s_Parser; //Field offset: 0x0

	[Address(RVA = "0x1068E70", Offset = "0x1068070", Length = "0x6D")]
	[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase+<ApplyBodyParts>d__62", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase+<ApplyHats>d__60", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController+<ImportMeshAsync>d__18", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfBoundsAsset+<Load>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GltfImportBase`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDownloadProvider), typeof(IDeferAgent), typeof(IMaterialGenerator), typeof(ICodeLogger)}, ReturnType = typeof(void))]
	[Token(Token = "0x600007A")]
	public GltfImport(IDownloadProvider downloadProvider = null, IDeferAgent deferAgent = null, IMaterialGenerator materialGenerator = null, ICodeLogger logger = null) { }

	[Address(RVA = "0x1068DB0", Offset = "0x1067FB0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GltfJsonUtilityParser), Member = "ParseJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RootBase))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600007B")]
	protected virtual RootBase ParseJson(string json) { }

}

