// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/company.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcService {

  /// <summary>Holder for reflection information generated from Protos/company.proto</summary>
  public static partial class CompanyReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/company.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompanyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRQcm90b3MvY29tcGFueS5wcm90bxIHY29tcGFueSJ9CghFbXBsb3llZRIT",
            "CgtlbXBsb3llZV9pZBgBIAEoBRISCgpmaXJzdF9uYW1lGAIgASgJEhEKCWxh",
            "c3RfbmFtZRgDIAEoCRIQCghsb2NhdGlvbhgEIAEoCRISCgpkZXBhcnRtZW50",
            "GAUgASgJEg8KB3NlYXRfbm8YBiABKAkiFwoVR2V0QWxsRW1wbG95ZWVzUGFy",
            "YW1zIjAKCUVtcGxveWVlcxIjCghlbXBsb3llZRgBIAMoCzIRLmNvbXBhbnku",
            "RW1wbG95ZWUykQEKC0NvbXBhbnlJbmZvEjsKE0dldEVtcGxveWVlRm9yRW1w",
            "SWQSES5jb21wYW55LkVtcGxveWVlGhEuY29tcGFueS5FbXBsb3llZRJFCg9H",
            "ZXRBbGxFbXBsb3llZXMSHi5jb21wYW55LkdldEFsbEVtcGxveWVlc1BhcmFt",
            "cxoSLmNvbXBhbnkuRW1wbG95ZWVzQg6qAgtHcnBjU2VydmljZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.Employee), global::GrpcService.Employee.Parser, new[]{ "EmployeeId", "FirstName", "LastName", "Location", "Department", "SeatNo" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.GetAllEmployeesParams), global::GrpcService.GetAllEmployeesParams.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.Employees), global::GrpcService.Employees.Parser, new[]{ "Employee" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Employee : pb::IMessage<Employee>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Employee> _parser = new pb::MessageParser<Employee>(() => new Employee());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Employee> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.CompanyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employee() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employee(Employee other) : this() {
      employeeId_ = other.employeeId_;
      firstName_ = other.firstName_;
      lastName_ = other.lastName_;
      location_ = other.location_;
      department_ = other.department_;
      seatNo_ = other.seatNo_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employee Clone() {
      return new Employee(this);
    }

    /// <summary>Field number for the "employee_id" field.</summary>
    public const int EmployeeIdFieldNumber = 1;
    private int employeeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EmployeeId {
      get { return employeeId_; }
      set {
        employeeId_ = value;
      }
    }

    /// <summary>Field number for the "first_name" field.</summary>
    public const int FirstNameFieldNumber = 2;
    private string firstName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FirstName {
      get { return firstName_; }
      set {
        firstName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_name" field.</summary>
    public const int LastNameFieldNumber = 3;
    private string lastName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LastName {
      get { return lastName_; }
      set {
        lastName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "location" field.</summary>
    public const int LocationFieldNumber = 4;
    private string location_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Location {
      get { return location_; }
      set {
        location_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "department" field.</summary>
    public const int DepartmentFieldNumber = 5;
    private string department_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Department {
      get { return department_; }
      set {
        department_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "seat_no" field.</summary>
    public const int SeatNoFieldNumber = 6;
    private string seatNo_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SeatNo {
      get { return seatNo_; }
      set {
        seatNo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Employee);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Employee other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EmployeeId != other.EmployeeId) return false;
      if (FirstName != other.FirstName) return false;
      if (LastName != other.LastName) return false;
      if (Location != other.Location) return false;
      if (Department != other.Department) return false;
      if (SeatNo != other.SeatNo) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EmployeeId != 0) hash ^= EmployeeId.GetHashCode();
      if (FirstName.Length != 0) hash ^= FirstName.GetHashCode();
      if (LastName.Length != 0) hash ^= LastName.GetHashCode();
      if (Location.Length != 0) hash ^= Location.GetHashCode();
      if (Department.Length != 0) hash ^= Department.GetHashCode();
      if (SeatNo.Length != 0) hash ^= SeatNo.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (EmployeeId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(EmployeeId);
      }
      if (FirstName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FirstName);
      }
      if (LastName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LastName);
      }
      if (Location.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Location);
      }
      if (Department.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Department);
      }
      if (SeatNo.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(SeatNo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (EmployeeId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(EmployeeId);
      }
      if (FirstName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FirstName);
      }
      if (LastName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LastName);
      }
      if (Location.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Location);
      }
      if (Department.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Department);
      }
      if (SeatNo.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(SeatNo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EmployeeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EmployeeId);
      }
      if (FirstName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FirstName);
      }
      if (LastName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LastName);
      }
      if (Location.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Location);
      }
      if (Department.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Department);
      }
      if (SeatNo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SeatNo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Employee other) {
      if (other == null) {
        return;
      }
      if (other.EmployeeId != 0) {
        EmployeeId = other.EmployeeId;
      }
      if (other.FirstName.Length != 0) {
        FirstName = other.FirstName;
      }
      if (other.LastName.Length != 0) {
        LastName = other.LastName;
      }
      if (other.Location.Length != 0) {
        Location = other.Location;
      }
      if (other.Department.Length != 0) {
        Department = other.Department;
      }
      if (other.SeatNo.Length != 0) {
        SeatNo = other.SeatNo;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            EmployeeId = input.ReadInt32();
            break;
          }
          case 18: {
            FirstName = input.ReadString();
            break;
          }
          case 26: {
            LastName = input.ReadString();
            break;
          }
          case 34: {
            Location = input.ReadString();
            break;
          }
          case 42: {
            Department = input.ReadString();
            break;
          }
          case 50: {
            SeatNo = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            EmployeeId = input.ReadInt32();
            break;
          }
          case 18: {
            FirstName = input.ReadString();
            break;
          }
          case 26: {
            LastName = input.ReadString();
            break;
          }
          case 34: {
            Location = input.ReadString();
            break;
          }
          case 42: {
            Department = input.ReadString();
            break;
          }
          case 50: {
            SeatNo = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GetAllEmployeesParams : pb::IMessage<GetAllEmployeesParams>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAllEmployeesParams> _parser = new pb::MessageParser<GetAllEmployeesParams>(() => new GetAllEmployeesParams());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAllEmployeesParams> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.CompanyReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllEmployeesParams() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllEmployeesParams(GetAllEmployeesParams other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllEmployeesParams Clone() {
      return new GetAllEmployeesParams(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetAllEmployeesParams);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAllEmployeesParams other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetAllEmployeesParams other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

  }

  public sealed partial class Employees : pb::IMessage<Employees>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Employees> _parser = new pb::MessageParser<Employees>(() => new Employees());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Employees> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.CompanyReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employees() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employees(Employees other) : this() {
      employee_ = other.employee_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employees Clone() {
      return new Employees(this);
    }

    /// <summary>Field number for the "employee" field.</summary>
    public const int EmployeeFieldNumber = 1;
    private static readonly pb::FieldCodec<global::GrpcService.Employee> _repeated_employee_codec
        = pb::FieldCodec.ForMessage(10, global::GrpcService.Employee.Parser);
    private readonly pbc::RepeatedField<global::GrpcService.Employee> employee_ = new pbc::RepeatedField<global::GrpcService.Employee>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GrpcService.Employee> Employee {
      get { return employee_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Employees);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Employees other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!employee_.Equals(other.employee_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= employee_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      employee_.WriteTo(output, _repeated_employee_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      employee_.WriteTo(ref output, _repeated_employee_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += employee_.CalculateSize(_repeated_employee_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Employees other) {
      if (other == null) {
        return;
      }
      employee_.Add(other.employee_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            employee_.AddEntriesFrom(input, _repeated_employee_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            employee_.AddEntriesFrom(ref input, _repeated_employee_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code