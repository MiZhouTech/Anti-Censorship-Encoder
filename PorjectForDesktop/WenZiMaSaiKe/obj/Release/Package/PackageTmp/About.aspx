<%@ Page Title="使用细节" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WenZiMaSaiKe.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>如何使用文字打码器？</h3>
    <p>使用一串类似软件序列号的字符，如： <strong>开始-第二栏-第三栏-a-b-c-d-e-f-1-2-2-4-5-6-结束</strong>，
        点击“打码”后就可以将原始文本转换成由你提供的字符加密的加密文本。 </p>
    <p>你也可以反过来，使用“解码”将他人提供的密码和密文得到原文。</p>
    <p>用来加密的字符串是可以自定义的！最多可以写16组字词，写不满会有默认的标点符号补位，不过请尽量写满16组字词，并且每组之间不要互相重复，否则这串字符可能无效哦。</p>
    <p>在代码中使用标点符号、空格，甚至换行号，都是可以的。不过，当神秘代码过短时，请慎用标点符号尤其是英文标点（半角）！
        因为标点符号被设置为加密字符不足16组时的补位字符，而英文标点是优先使用的。
        但如果你写满了16组字词，其中的任意一组都可以随便改成标点符号，当然，每组之间互相不能完全重复。</p>
    <p>目前本应用只是测试版哟！开发者无法保证加密代码时刻起作用，所以在加密后请试试解密看看能否顺利推导回原文。</p>
    <p>新文本会比原文长很多，这是一个问题！另外目前使用的算法还很简陋，欢迎各位前来探讨更好的解决方案。</p>
    <p>有任何疑问或建议，请找开发者哟。</p>

    <hr />
    <address>

        <strong>来渣浪微博找开发者：</strong>   <a href="https://www.weibo.com/TechLizard" target="_blank">@技术宅痴女</a><br />
        <strong>本应用的GitHub地址：</strong>   <a href="https://github.com/TechMiZ/Anti-Censorship-Encoder" target="_blank">羞耻的源码</a><br />
        <strong>本应用的Win10桌面版下载：</strong>   
        <a href="https://github.com/TechMiZ/Anti-Censorship-Encoder/raw/master/文字打码助手-测试版v0.0.0.exe" target="_blank">Win10桌面版专供断网使用</a>
        
    </address>
</asp:Content>
