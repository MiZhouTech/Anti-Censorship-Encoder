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

            <h2>输入神秘代码（或选默认选项）：</h2>
            <p>（格式： <strong>用杠-分割的-替换字符-最长-可-16组-字词-互相-不能-重复-，-不足时-会有-默认-标点-补位</strong>）</p>
            
            <asp:TextBox ID="KeyString" runat="server" TextMode="MultiLine" Width="100%" >…-日李-万机-口不-？-泽言-一言-九鼎-食言-交浅-言深-言大-非夸-妙不-可言-！</asp:TextBox>
            <br />
            <asp:DropDownList ID="DefaultKeys" runat="server" Width="100%" 
                onClick="var selection = document.getElementById('MainContent_DefaultKeys');
                var text = document.getElementById('MainContent_KeyString');
                text.innerText = selection.value;">
                <asp:ListItem Value="…-日李-万机-口不-？-泽言-一言-九鼎-食言-交浅-言深-言大-非夸-妙不-可言-！">默认选项A-老司机示例</asp:ListItem>
                <asp:ListItem Value="love -me -Love -Me -LOVE -ME -like -Like -LIKE -you -You -YOU -kiss -Kiss -KISS -do ">默认选项B-英文写诗版（最后一组结尾带一个空格）</asp:ListItem>
                <asp:ListItem Value="好美-好甜-好萌-好Q-好软-好帅-好燃-好酷-好炫-啊-哎-哦-噢-呀-喔-哇">默认选项C-感叹版</asp:ListItem>
                <asp:ListItem Value="富-强-文-明-爱-国-敬-业-诚-信-友-善-、-，-。-！">默认选项D-核心价值版</asp:ListItem>
                <asp:ListItem Value="以热爱祖国为荣。-以危害祖国为耻。-以服务人民为荣。-以背离人民为耻。-以崇尚科学为荣。-以愚昧无知为耻。-以辛勤劳动为荣。-以好逸恶劳为耻。-以团结互助为荣。-以损人利己为耻。-以诚实守信为荣。-以见利忘义为耻。-以遵纪守法为荣。-以违法乱纪为耻。-以艰苦奋斗为荣。-以骄奢y逸为耻。">默认选项E-荣辱观版</asp:ListItem>
                <asp:ListItem Value="零-一-二-三-四-五-六-七-八-九-十-百-千-万-亿-兆">默认选项F-数字版</asp:ListItem>
            </asp:DropDownList>
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
