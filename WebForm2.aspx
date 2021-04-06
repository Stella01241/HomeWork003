<%@ Page Title="" Language="C#" MasterPageFile="~/Home003.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="HomeWork003.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /*.thStyle{
            width:100px;
            text-align:left;
        }*/
        .sid{
            width:50px;
            text-align:left;
        }
        .equipment_name{
             width:100px;
            text-align:left;
        }
          .restoration_time{
             width:100px;
            text-align:left;
        }
           .failure_date{
             width:100px;
            text-align:left;
        }
            .restoration_factory{
             width:80px;
            text-align:left;
        }

         .failure_cause{
             width:80px;
            text-align:left;
        }
     
         
       
        .replacement_department{
             width:80px;
            text-align:left;
        }
        .note{
             width:50px;
            text-align:left;
        }
       
    </style>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <div>
        <%--用Div標籤包住span跟textbox,作為輸出欄位,做出欄為標題--%>
        <div>
            <span>sid:</span>
            <asp:TextBox ID="TextSid" runat="server"></asp:TextBox>

        </div>
        <div>
            <span>設備名稱:</span>
            <asp:TextBox ID="Textequipment_name" runat="server"></asp:TextBox>

        </div>
        <div>
            <span>送修時間:</span>
            <asp:TextBox ID="Textrestoration_time" runat="server"></asp:TextBox>

        </div>
        <div>
            <span>故障日期:</span>
            <asp:TextBox ID="Textfailure_date" runat="server"></asp:TextBox>

        </div>
        <div>
            <span>維修廠商:</span>
            <asp:TextBox ID="Textrestoration_factory" runat="server"></asp:TextBox>

        </div>
        <div>
            <span>故障原因:</span>
            <asp:TextBox ID="Textfailure_cause" runat="server"></asp:TextBox>

        </div>
        <div>
            <span>更換部件:</span>
            <asp:TextBox ID="Textreplacement_department" runat="server"></asp:TextBox>

        </div>
        <div>
            <span>備註:</span>
            <asp:TextBox ID="Textnote" runat="server"></asp:TextBox>

        </div>
        <%--新增按鈕匿名ID--%>
        <asp:Button ID="btnCreate" runat="server" Text="新增" OnClick="btnCreate_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="修改" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="刪除" OnClick="btnDelete_Click" />
        <asp:Button ID="btnSingleRead" runat="server" Text="單筆查詢" OnClick="Single_Click" />
        <asp:Button ID="btnReadAll" runat="server" Text="顯示所有" OnClick="ReadAll_Click" />
        <asp:Button ID="btnChange" runat="server" Text="查詢其他" OnClick="Chang_Click" />




        <%--用GridView來顯示資料表--%>
        <%--  <asp:GridView runat="server" ID="GridView1"></asp:GridView>--%>
        
        <table>
            <tr>
                 <th class="thStyle sid">編號</th>
                 <th class="thStyle equipment_name">設備名稱</th>
                 <th class="thStyle restoration_time">維修時間</th>
                 <th class="thStyle failure_date">故障日期</th>
                 <th class="thStyle restoration_factory">維修廠商</th>
                 <th class="thStyle failure_cause">故障原因</th>
                 <th class="thStyle replacement_department">更換部件</th>
                 <th class="thStyle note">備註</th>
            </tr>

            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                    <td><%# Eval("sid")%></td>
                    <td><%# Eval("equipment_name")%> </td>
                    <td><%# Eval("restoration_time","{0:yyyy-MM-dd }")%></td>
                    <td><%# Eval("failure_date","{0:yyyy-MM-dd }")%></td>
                    <td><%# Eval("replacement_department")%></td>
                    <td><%# Eval("note")%></td>
                     </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
            


       

    </div>
</asp:Content>
