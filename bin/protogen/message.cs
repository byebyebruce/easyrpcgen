//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: message.proto
namespace message
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TeamCharacterOne")]
  public partial class TeamCharacterOne : global::ProtoBuf.IExtensible
  {
    public TeamCharacterOne() {}
    
    private ulong _CharacterId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CharacterId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong CharacterId
    {
      get { return _CharacterId; }
      set { _CharacterId = value; }
    }
    private string _CharacterName;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CharacterName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string CharacterName
    {
      get { return _CharacterName; }
      set { _CharacterName = value; }
    }
    private int _RoleId;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RoleId
    {
      get { return _RoleId; }
      set { _RoleId = value; }
    }
    private int _Level;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level
    {
      get { return _Level; }
      set { _Level = value; }
    }
    private int _Ladder;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Ladder", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Ladder
    {
      get { return _Ladder; }
      set { _Ladder = value; }
    }
    private int _FightPoint;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"FightPoint", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FightPoint
    {
      get { return _FightPoint; }
      set { _FightPoint = value; }
    }
    private int _QueueResult = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"QueueResult", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int QueueResult
    {
      get { return _QueueResult; }
      set { _QueueResult = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}