namespace Polytoria.Controllers;

[Token(Token = "0x2000444")]
public class CreatorMenuCmdController : MonoBehaviour
{

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D11")]
	public CreatorMenuCmdController() { }

	[Address(RVA = "0x4EC590", Offset = "0x4EB790", Length = "0x1161")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CreatorController), Member = "AddScript", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance), typeof(bool)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTUndoRedo), Member = "Undo", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTUndoRedo), Member = "Redo", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "DeleteSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "DuplicateSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "GroupSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "UngroupSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "FileOpen", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "ExportGLTF", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "FileSave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "PromptExit", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CreatorController), Member = "AddRemoteEvent", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CreatorController), Member = "PublishGame", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "AddUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "AddModuleScript", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "AddLocalScript", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "AddPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartShape), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CreatorController), Member = "PublishModel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "ExportModel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "ImportModel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "TestGame", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CreatorController), Member = "ClearWorkspace", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 33)]
	[Token(Token = "0x6002D10")]
	public void OnCmd(string cmd) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D0E")]
	public void OnValidateCmd(MenuItemValidationArgs args) { }

	[Address(RVA = "0x4ED700", Offset = "0x4EC900", Length = "0x325")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CreatorController), Member = "FileSave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "UngroupSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "FileOpen", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "ClearWorkspace", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "PublishGame", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "GroupSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "DuplicateSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "TestGame", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Token(Token = "0x6002D0F")]
	private void Update() { }

}

