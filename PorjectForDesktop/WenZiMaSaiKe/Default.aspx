<%@ Page Title="开始打码" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WenZiMaSaiKe._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>~文字打码~再也不想发帖留言写文被吞了TAT</h1>
        <p class="lead">为什么我写的内容一发秒被吞，或根本无法过审？为什么我爱的写文太太再也不敢大胆产粮？快把打码器告诉你在乎的人吧！</p>
    </div>

    <div class="row">

        <div class="col-md-4">
            <p>这里输入你想打码的内容，或显示右边密文被解码的结果：</p>
            <asp:TextBox ID="KeyString0" runat="server" Height="300px" TextMode="MultiLine" Width="100%" ></asp:TextBox>
                
        </div>
        <div class="col-md-4">
            
            <h2>输入神秘代码：</h2>
            <p>（格式： <strong>用杠-分割的-替换字符-最长-可-16组-字词-互相-不能-重复-，-不足时-会有-默认-标点-补位</strong>）</p>
            
            <asp:TextBox ID="KeyString" runat="server" TextMode="MultiLine" Width="100%" ></asp:TextBox>

            <p>
                <asp:Button ID="Encode" runat="server" CssClass="btn btn-default" Text="打码 &gt;&gt;" />
            </p>
            <p>
                <asp:Button ID="Decode" runat="server" CssClass="btn btn-default" Text="&lt;&lt; 解码" />
            </p>
        </div>
        <div class="col-md-4">
            <p>这里输入你想解码的内容，或显示左边原文已打码的结果：</p>
            <asp:TextBox ID="KeyString1" runat="server" Height="300px" TextMode="MultiLine" Width="100%" ></asp:TextBox>

        </div>
    </div>

</asp:Content>
