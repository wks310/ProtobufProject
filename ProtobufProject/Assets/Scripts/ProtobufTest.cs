#region 模块信息
//=====================================================
// - Company(公司)：大连创模科技
// - FileName(文件名):      ProtobufTest.cs
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
using System.IO;
using ProtoBuf;

public class ProtobufTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
         // Serialization();
        NotSerialization();


    }
    /// <summary>
    /// 序列化User里面的信息内容
    /// </summary>
    void Serialization() {
       

        User user = new User();
        user.ID = 21;
        user.UserName = "爱尚游Bin";
        user.Password = "123456";
        user.Level = 4;
        user._UserType = User.UserType.Warrior;

        using (var fs = File.Create(Application.streamingAssetsPath + "/user.bin"))
        {
            Serializer.Serialize<User>(fs, user);//把user对象序列化出二进制文件放入fs文件里面
           
        }
    }
    /// <summary>
    /// 反序列化User里面的信息内容
    /// </summary>
    void NotSerialization() {
        User user = null;
        using (var fs=File.OpenRead(Application.streamingAssetsPath+"/user.bin")) {
            user = Serializer.Deserialize<User>(fs);//反序列化
        }
        Debug.Log(string.Format("ID:{0},用户名：{1}，密码：{2}，等级：{3}，角色类型：{4}",user.ID,user.UserName,user.Password,user.Level,user._UserType));

    }
}
