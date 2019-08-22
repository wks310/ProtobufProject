#region 模块信息
//=====================================================
// - Company(公司)：大连创模科技
// - FileName(文件名):      user.cs
// - Created(作者):         #AuthorName#
// - CreateTime(创建时间):  #CreateTime#
// - Email(邮箱):           #AuthorEmail#
// - Description(脚本说明):   
// - Modifier(修改者列表)： 
// -  
//======================================================
#endregion
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProtoBuf;

[ProtoContract]
public class User {
    [ProtoMember(1)]
    public int ID { get; set; }
    [ProtoMember(2)]
    public string UserName { get; set; }
    [ProtoMember(3)]
    public string Password { get; set; }
    [ProtoMember(4)]
    public int Level { get; set; }
    [ProtoMember(5)]
    public UserType _UserType { get; set; }
    public enum UserType {
        Master,
        Warrior
    }
}
