<%@ Page Title="开始打码" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WenZiMaSaiKe._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 style="font-size: xx-large">~文字打码~再也不想发帖留言写文被吞了TAT</h1>
        <p style="font-size: large">为什么我写的内容一发秒被吞，或根本无法发出？为什么我爱的写文太太再也不敢大胆产粮？快把打码器告诉你在乎的人吧！</p>
    </div>
    
    <div class="row">

        <div class="col-md-4">
            <asp:TextBox ID="RawText" runat="server" Height="333px" TextMode="MultiLine" Width="100%" placeholder="这里输入你想打码的内容，或显示右边（或下面）密文被解码的结果："></asp:TextBox>
                
        </div>
        <div class="col-md-4" style="text-align: center">
            <asp:Label ID="ErrorTips" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:Label ID="ErrorText" runat="server" ForeColor="Red"></asp:Label>

            <h2>输入神秘代码：</h2>
            <p>（格式： <strong>用杠-分割的-替换字符-最长-可-16组-字词-互相-不能-重复-，-不足时-会有-默认-标点-补位</strong>）</p>
            
            <asp:TextBox ID="KeyString" runat="server" TextMode="MultiLine" Width="100%" ></asp:TextBox>
            <br />
            <br />
            <p>
                <asp:Button ID="Encode" runat="server" CssClass="btn btn-default" Text="打码 &gt;&gt;" OnClick="Encode_Click" />
                <asp:Button ID="Decode" runat="server" CssClass="btn btn-default" Text="&lt;&lt; 解码" OnClick="Decode_Click" />
            </p>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="EncryptedText" runat="server" Height="333px" TextMode="MultiLine" Width="100%" placeholder="这里输入你想解码的内容，或显示左边（或上面）原文已打码的结果："></asp:TextBox>

        </div>
    </div>

    <hr />
    <address>

        <strong>来渣浪微博找开发者：</strong>   <a href="https://www.weibo.com/TechLizard" target="_blank">@技术宅痴女</a><br />
        <strong>本应用的GitHub地址：</strong>   <a href="https://github.com/TechMiZ/Anti-Censorship-Encoder" target="_blank">羞耻的源码</a><br />
        <strong>本应用的Win10桌面版下载：</strong>   
        <a href="https://github.com/TechMiZ/Anti-Censorship-Encoder/raw/master/文字打码助手-测试版v0.0.0.exe" target="_blank">Win10桌面版专供断网使用</a>
        
    </address>

</asp:Content>
