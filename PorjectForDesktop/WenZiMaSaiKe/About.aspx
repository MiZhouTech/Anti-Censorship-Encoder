<%@ Page Title="使用细节" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WenZiMaSaiKe.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>如何使用文字打码器？</h3>
    <p>使用一串类似软件序列号的字符，如： <strong>开始-第二栏-第三栏-a-b-c-d-e-f-1-2-2-4-5-6-结束</strong>，点击“打码”后就可以将原始文本转换成由你提供的字符加密的加密文本。 </p>
    <p>你也可以反过来，使用“解码”将他人提供的密码和密文得到原文。</p>
    <p>用来加密的字符串是可以自定义的！最多可以写16组字词，写不满会有默认的标点符号补位，不过请尽量写满16组字词，并且每组之间不要互相重复，否则这串字符可能无效哦。</p>
    <p>目前本应用只是测试版哟！开发者无法保证加密代码时刻起作用，所以在加密后请试试解密看看能否顺利推导回原文。</p>
    <p>新文本会比原文长很多，这是一个问题！</p>
    <p>有任何疑问或建议，请找开发者哟。</p>
</asp:Content>
