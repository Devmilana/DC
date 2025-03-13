using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankDataService.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Sarah Taylor", 5187m, new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 2,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Emily Smith", 6468m, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 3,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "James Johnson", 4535m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 4,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Olivia Davis", 6669m, new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 5,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Laura Johnson", 7693m, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 6,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Jane Garcia", 3205m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 7,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Michael Martinez", 4980m, new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 8,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "David Williams", 9919m, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 9,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Michael Williams", 4124m, new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 10,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Sarah Martinez", 3398m, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1,
                columns: new[] { "Amount", "TransactionDate" },
                values: new object[] { 863m, new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2,
                columns: new[] { "Amount", "TransactionDate" },
                values: new object[] { 814m, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 1, 827m, new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 1, 298m, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5,
                columns: new[] { "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 220m, new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 2, 61m, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 2, 887m, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 8,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 3, 276m, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 9,
                columns: new[] { "Amount", "TransactionDate" },
                values: new object[] { 692m, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 10,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 4, 110m, new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 11,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 4, 513m, new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 12,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 5, 809m, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 13,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 5, 277m, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 14,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 5, 655m, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 15,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 6, 829m, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 16,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 6, 208m, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 17,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 6, 280m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 18,
                columns: new[] { "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 974m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 19,
                columns: new[] { "Amount", "TransactionDate" },
                values: new object[] { 499m, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 20,
                columns: new[] { "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 165m, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 21,
                columns: new[] { "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 351m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 22,
                columns: new[] { "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 894m, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 23,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 9, 307m, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 24,
                columns: new[] { "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 876m, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 25, 10, 99m, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 26, 10, 247m, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 1,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "499 Oak St, San Diego", "sarah.taylor@gmail.com", "Sarah Taylor", "passwordSarah", "112-950-9745", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAANoSURBVHhe7ZTRbuMwEAPz/z+dg3AXIBfQsmxLu6SWA8xrveK0fb1NSRy+KA5fFIcvisMXxeGL4vBFcfiiOHxRHL4oDl8Uhy+KwxfF4Yvi8EVx+KI4fFEcvigOXxSHL4rDF8Xhi+LwRXH4ojh8UbYP/3q9brk7W70QBZzpTsi/BgWKUB3JF6AQmSoidTUanUklZK5FQ7OqAP2VaFgF2aG+EA2qJiu0l6ERVWWE8io0nrps0F2ERttFJqiuQWM99S7oZ82QBZpL0Eh3XAX61h1Z2CZ8JOj7V2SA4go0zqhZoFuumI10eAbQXSNmk34BGuVMNtCNI2bi8JNAd56ZSerX0RhnMoPuPTMLqfDsoJvPzMLhJ4Pu7pmFw08G3X1mBjLhlUD398zA4ReA7u+ZgcMvAN3fM4O0RdEAPZVA9/fMIHVRNMKRaqA3HJmBwxdFJnzTzMPhiyIVvmnmIBe+aZ6TviIKO6J5hmz4prmPdPiP5joUq6GYdzVj0CyFIj7VHLN1+G/N/1AtgoKtsjp0C6BIUVaC8rUoSoY7Q/s6FCLbnaB/DQrAoDoSL0DDM6mI1NVodCaVkPx1RaMzqYDm/6l/oNGZZEY6/DdoeBYZ2Sb8LyhApmxsG/4XFCNDFsqE/wVFiZKBsuF/QYFWmo3DH4BizTYThx8ARZtlFg5/ERTviVk4/ANQyDtm4PATQDGvmIHDTwRFHTUah58MijpiNA6/ABR2xEgcfhEo7JmROPwiUNgzI3H4haC4PSMJ/Rp6bE910Jt6RuLwi0HvOjKS8HXRg4/cAfSuIyNx+MWgd/WMgjp8Ux30piMjcfjFoDcdGYnDLwa96chI6MM3lUHvOTKSlFXRo3uqgt7SMxKJ8E1F0Dt6RiITvqkGekPPSNLWRA8/Uwl0f89opMI3FUB3nxlN6pJogBGZQfeOGI1k+CYj6M4RM0hfEA1xRRbQbaNmIB/+YybonlGzoPiTQYPcNRL0/StmQhG+gYZ56grQd+6aCU34BhpnpndAP2eG2VCFb6CRdpMBuvANNNYuskAZvoFGU5cJ2vANNJ6qbFCHb6ARlWSFPvwHNCq7zMiE/4AGZlMBufAf0ODZKiEb/hsUIVJFtgj/C4oz0x3YMnwPFPLInSkX3vzF4Yvi8EVx+KI4fFEcvigOX5L3+w+v/DGd3p4PCQAAAABJRU5ErkJggg==" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 2,
                columns: new[] { "Address", "Email", "Name", "Phone" },
                values: new object[] { "614 Highland Ave, San Jose", "emily.smith@gmail.com", "Emily Smith", "338-476-6474" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 3,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "123 Birch St, Houston", "james.johnson@gmail.com", "James Johnson", "passwordJames", "818-473-6458", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAIvSURBVHhe7dFBbsJQEARR7n9pIlaJopHtTsD+rq4n9RKs+fV4qpLhSxm+lOFLGb6U4UsZvpThSxm+lOFLGb6U4UsZvpThSxm+lOFLGb6U4UsZvpThSxm+lOFLGb6U4UsZvpThSxm+VHX4x+MRjcTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFITrlmesStnWX69tZIDB+MxPDBSAwfjKQ2/PTdrdEY/uBolgz/2qdN39wajeEPjsbwB0dz2kXTY27tk6bv7Y1m2fCvfcr0ra0RGf7AiJYO/9q7Td/YG9GpV02PemTvMv333qhuEf61/5r+88ioTr9setyj+4vpf5JR3Sr8z+2ZfpOO7JLrpkdecWSXXTc99EqjM/ywBpdeOT36Cmtw+ZXTw1+5FktcOgU4e22WungKcsYaLXf1FOaTa7Xs5VOkd67dLV5gCveX6dstX2OK+nva5guVMnwpw5cyfCnDlzJ8KcNXej6/ADqIE4A0DE9uAAAAAElFTkSuQmCC" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 4,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "155 Birch St, Chicago", "olivia.davis@gmail.com", "Olivia Davis", "passwordOlivia", "464-814-8225", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAOnSURBVHhe7ZPRCmMhDAX7/z/dXR8KyzIY49XricnAPBVac4Z+vkVKKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKvxfPp+PyxtIFZ4irjQS14enQG+ozpXhKcRJFbkqPI2upBJXhKeRlVUgfHgaNoKnCRuexozoKUKGpwEje4JQ4Wm0W3ybMOFprJ3+oM92+hYhwtNAK3wKfecK30A+PA3zxJ3Q7826G+nwNMiMb0NvmHEnsuFpiBlPQW+ZcRfXhleB3uZxF5LhaQCPatAbPe5AbiU63KMy9N5RVyO1FB08ahTo7aOu5Irw0aAbRlyJzGp06IhRoVtGXEWFPwTdMuIqJJajA0eMDt004gqOr0eHjXgLdJvlCkKGvwm6b8SnVHgB6EbLpxxdkQ6yvBW61fIJFV4EutXyCceWpENGvBW61fIJocLfDt1sOUuFF4JutpzlyJp0gGUW6Paes1R4Meh2yxkqvBh0u+UMFV4Mut1yhhDhs0Eb9Jzh9VXp4ZbZoA16zlDhBaENLL1UeEFoA0svFV4Q2sDSi3z4jNAOll4qvCC0g6WXCi8KbdHTS4UXhbbo6aXCi0Jb9PRS4UWhLXp6qfCi0BY9vVR4UWiLnl4qvCi0RU8vFV4U2qKnlwovCm3R00uFF4W26OmlwgtCO1h6qfCC0A6WXuTDN7NBG1h6qfCC0AaWXiq8ILSBpZcKLwht0HOGI6vS43tmgzboOUOI8M0s0O2WM1R4Meh2yxkqvBh0u+UMxxalA3pmgW7vOUuY8M3boZstZ6nwQtDNlrOECt+8FbrV8glHl6RjLG+FbrV8QoUXgO4c8QnHl6SDLG+DbrR8SsjwzVug20Z8isSCdJjlLdBtlisIG74ZHbppxBXIrEcHjhgVumXEVVT4Q9AtI65Cajk6dMRo0A0jruSK8M0I0LtHXY3cYnS0R1XorR5XI7kUHe5RDXqjxx3I/kVoAI8q0Ns87kI2fIOG8HoKeovXnVwfvvk29IYZdyIdvkGDPHEX9FtP3I18+AYNs8Kn0Heu8A1ChG/QQDv9QZ/t9C3ChP9BY93g24QL36DhInuCkOEbNGBETxE2/A8aM4KnCR++QcMqq8AV4X/QyEoqcVX4HzT6SRW5Mvy/UIg3VOf68P9DkVYZiXThCYrY8wYqfFIqfFIqfFIqfFIqfFIqfFIqfEq+3z8+b1xWzv2W6AAAAABJRU5ErkJggg==" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 5,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "857 Maple St, Dallas", "laura.johnson@gmail.com", "Laura Johnson", "passwordLaura", "501-862-8351", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAFTSURBVHhe7dHBCcNAEATByz/pUwwGL1rRVTD/gT6XJOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI96Pfw556fxH8JHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfNTnwn9tWwk/vK2EH95Wwg9vK+GHt5Xww9tK+OFtJfzwthJ+eFsJP7yt9j5jlPBRwkcJHyV8lPBRwkcJHyV80r0PU2FnLFKaa9EAAAAASUVORK5CYII=" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 6,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "575 Cedar Ave, Dallas", "jane.garcia@gmail.com", "Jane Garcia", "passwordJane", "103-178-9103", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAIvSURBVHhe7dFBbsJQEARR7n9pIlaJopHtTsD+rq4n9RKs+fV4qpLhSxm+lOFLGb6U4UsZvpThSxm+lOFLGb6U4UsZvpThSxm+lOFLGb6U4UsZvpThSxm+lOFLGb6U4UsZvpThSxm+VHX4x+MRjcTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFITrlmesStnWX69tZIDB+MxPDBSAwfjKQ2/PTdrdEY/uBolgz/2qdN39wajeEPjsbwB0dz2kXTY27tk6bv7Y1m2fCvfcr0ra0RGf7AiJYO/9q7Td/YG9GpV02PemTvMv333qhuEf61/5r+88ioTr9setyj+4vpf5JR3Sr8z+2ZfpOO7JLrpkdecWSXXTc99EqjM/ywBpdeOT36Cmtw+ZXTw1+5FktcOgU4e22WungKcsYaLXf1FOaTa7Xs5VOkd67dLV5gCveX6dstX2OK+nva5guVMnwpw5cyfCnDlzJ8KcNXej6/ADqIE4A0DE9uAAAAAElFTkSuQmCC" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 7,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "936 Elm St, Dallas", "michael.martinez@gmail.com", "Michael Martinez", "passwordMichael", "339-619-5436", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAR5SURBVHhe7ZHRiq0wEAT3/3/63g2cBZFqbWOiR6cL6slkJlI//0JJEr4oCV+UhC9Kwhcl4YuS8EVJ+KIkfFESvigJX5SEL0rCFyXhi5LwRUn4oiR8URK+KAlflIQvSsIXJeGLkvBFSfiiJHxREr4oCV+U28P//PwM8Q3Qf/XokPBfAv1Trw6vCd98MvQ/vTok/JdA/9OrQ8J/AfQvZ3R4VfjmE6H/OKNDwn8B9B9ndEj4m6F/OKvD68I3nwS9/6wOCX8z9P6zOiT8jdDbR+jwyvDNJ0DvHqFDwt8IvXuEDgl/E/TmUTo8KnzP+W+F3qvsOb9Hwt8EvVfZc36PhL8BeuuWR+84PC58g74pvxF6p/IP+qZ0SPgboHcq/6BvSoeEvwF6p/IP+qZ0eGT4Bn1XfhP0PuUS+q50SPiLofcpl9B3pUPCXwy9T7mEvisdHhu+QWeU3wC9S7mGzigdEv5C6F3KNXRG6ZDwF0LvIgk6p3R4dPgGnSPvht6kJOic0qFM+Oad0HuUBJ1TOiT8RdB7SAWdVTo8PnyDzpJ3QW9RKuis0qFU+OYd0DuUCjqrdEj4C6B3kFvQeaXDK8I36Dx5NfQG5RZ0XulQLnzzSmi/cgs6r3RI+MnQfnIPuqN0eE34Bt0hr4J2K/egO0qHkuGbV0B7lXvQHaVDwk+E9pIOdE/p8KrwDbpHzoZ2Kh3ontKhbPjmTGif0oHuKR0SfhK0j3Shu0qH14Vv0F1yFrRL6UJ3lQ6lwzdnQHuULnRX6ZDwE6A95BHovtLhleEbdJ8cDe1QHoHuKx3Kh2+OhOYrj0D3lQ4J/+tIaD55FJqhdHht+AbNIEdBs5VHoRlKh4T/OAKaqzwKzVA6JPzHEdBcsgeao3R4dfgGzSHPQjOVPdAcpUPCLzwDzVP2QHOUDgm/8Aw0j+yFZikdXh++QbPIXmiWsheapXRI+JU90BxlLzRL6ZDwK3ugOeQZaJ7SoUT4Bs0jj0IzlGegeUqHhAePQPeVZ6B5SoeEB49A98mz0EylQ5nwDZpJutBd5VloptIh4YUOdE95FpqpdEh4oQPdI0dAc5UOpcI3aC65B91RjoDmKh0SfsMt6LxyBDRX6ZDwG25B58lR0GylQ7nwDZpNKuischQ0W+mQ8Bsq6KxyFDRb6ZDwOxJ0jhwJzVc6lAzfoPnkGjqjHAnNVzok/I5r6IxyJDRf6ZDwhkvoOzka2qF0KBu+QTvIJfSdHA3tUDokvOEf9E05GtqhdEh40yPnZ0B7lA6lwzdoD3n07Ghoj9Ih4WHPWWdAe5QOCQ97zjgL2qV0KB++Qbt6nQXtUjok/C+0q9dZ0C6lQ8L/Qrt6nAntUzok/Afad9SZ0D6lQ8J/oH1HnQntUzok/Afad8TZ0E6lQ8IvoJ2us6GdSoeEX0A7XWdDO5UOCb+AdjpeAe1VOiT8Ctq75xXQXqVDwq+gvXteAe1VOiT8Ctq75VXQbqVDwgO0W3kVtFvpcHv4cA8JX5SEL0rCFyXhi5LwRUn4oiR8URK+JP/+/QdKhfUicXLLiQAAAABJRU5ErkJggg==" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 8,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "859 Maple St, New York", "david.williams@gmail.com", "David Williams", "passwordDavid", "580-996-4026", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAK1SURBVHhe7dHRDcMwDAPR7r90uwBhOY0oOdE9gL+Jhft8MRLhhyL8UIQfivBDEX4owg9F+KEIPxThhyL8UIQfivBDEX4owg9F+KEIPxThhyL8UIQfivBDEX4owg9F+KEIPxThhyL8UO3hP5/P0Xsrwv+xNyB8wp6I8Il7EsIb9gSEN+9UhC/YiQhfuJMQvninIHzDTvC48A7qPxXrRPgN6h1Z60L4i9Sb7q4D4W9Q7/tnHQifQL3z6qoRPpF675VVInwy9eYrq0J4A/Xu3VUhvIl6++4qEN5IvX9nFQhvpm7YmRvhC6g7orkRvoC6Y2dOhC+ibonmRPgi6paduRC+kLonmgvhC6l7orkQvpi6aTUXwhdTN0VzIHwxdVM0B8I3UHet5kD4Buqu1RwI30DdFS0b4Ruou6JlI3wDdVe0bIRvom5bLRvhm6jbVstG+CbqttWyEb6Jum21bIRvom5bLRvhm6jbVstG+CbqtmiZCN9E3RYtE+GbqNuiZSJ8E3VbtEyEb6Jui5aJ8E3UbdEyEb6Jui1aJsI3Ubetlo3wTdRtq2UjfBN122rZCN9E3bZaNsI3Ubetlo3wTdRtq2UjfBN122rZCN9A3RUtG+EbqLuiZSN8A3XXag6Eb6DuWs2B8MXUTdEcCF9M3RTNgfDF1E3RHAhfSN0TzYXwhdQ90VwIX0jdE82F8EXULdGcCF9E3RLNifAF1B3R3Ahvpm7YmRvhzdQNO3MjvJF6/84qEN5EvX13FQhvoN69uyqET6bevLtKhE+k3ntllQifQL3z6qoR/gb1vn/WgfAXqTfdWRfCB9QbstZpdHj1/ap1e1z4N+wEhC/eKQhftNMQvmAnIrxxJyO8YU9A+MQ9CeFv7qkIf3FvQfhgb/Xey7BE+KEIPxThhyL8UIQfivBDEX4owo/0/f4ARZg+dAE/yWkAAAAASUVORK5CYII=" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 9,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "225 Cherry St, San Diego", "michael.williams@gmail.com", "Michael Williams", "passwordMichael", "974-439-7070", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAR5SURBVHhe7ZHRiq0wEAT3/3/63g2cBZFqbWOiR6cL6slkJlI//0JJEr4oCV+UhC9Kwhcl4YuS8EVJ+KIkfFESvigJX5SEL0rCFyXhi5LwRUn4oiR8URK+KAlflIQvSsIXJeGLkvBFSfiiJHxREr4oCV+U28P//PwM8Q3Qf/XokPBfAv1Trw6vCd98MvQ/vTok/JdA/9OrQ8J/AfQvZ3R4VfjmE6H/OKNDwn8B9B9ndEj4m6F/OKvD68I3nwS9/6wOCX8z9P6zOiT8jdDbR+jwyvDNJ0DvHqFDwt8IvXuEDgl/E/TmUTo8KnzP+W+F3qvsOb9Hwt8EvVfZc36PhL8BeuuWR+84PC58g74pvxF6p/IP+qZ0SPgboHcq/6BvSoeEvwF6p/IP+qZ0eGT4Bn1XfhP0PuUS+q50SPiLofcpl9B3pUPCXwy9T7mEvisdHhu+QWeU3wC9S7mGzigdEv5C6F3KNXRG6ZDwF0LvIgk6p3R4dPgGnSPvht6kJOic0qFM+Oad0HuUBJ1TOiT8RdB7SAWdVTo8PnyDzpJ3QW9RKuis0qFU+OYd0DuUCjqrdEj4C6B3kFvQeaXDK8I36Dx5NfQG5RZ0XulQLnzzSmi/cgs6r3RI+MnQfnIPuqN0eE34Bt0hr4J2K/egO0qHkuGbV0B7lXvQHaVDwk+E9pIOdE/p8KrwDbpHzoZ2Kh3ontKhbPjmTGif0oHuKR0SfhK0j3Shu0qH14Vv0F1yFrRL6UJ3lQ6lwzdnQHuULnRX6ZDwE6A95BHovtLhleEbdJ8cDe1QHoHuKx3Kh2+OhOYrj0D3lQ4J/+tIaD55FJqhdHht+AbNIEdBs5VHoRlKh4T/OAKaqzwKzVA6JPzHEdBcsgeao3R4dfgGzSHPQjOVPdAcpUPCLzwDzVP2QHOUDgm/8Aw0j+yFZikdXh++QbPIXmiWsheapXRI+JU90BxlLzRL6ZDwK3ugOeQZaJ7SoUT4Bs0jj0IzlGegeUqHhAePQPeVZ6B5SoeEB49A98mz0EylQ5nwDZpJutBd5VloptIh4YUOdE95FpqpdEh4oQPdI0dAc5UOpcI3aC65B91RjoDmKh0SfsMt6LxyBDRX6ZDwG25B58lR0GylQ7nwDZpNKuischQ0W+mQ8Bsq6KxyFDRb6ZDwOxJ0jhwJzVc6lAzfoPnkGjqjHAnNVzok/I5r6IxyJDRf6ZDwhkvoOzka2qF0KBu+QTvIJfSdHA3tUDokvOEf9E05GtqhdEh40yPnZ0B7lA6lwzdoD3n07Ghoj9Ih4WHPWWdAe5QOCQ97zjgL2qV0KB++Qbt6nQXtUjok/C+0q9dZ0C6lQ8L/Qrt6nAntUzok/Afad9SZ0D6lQ8J/oH1HnQntUzok/Afad8TZ0E6lQ8IvoJ2us6GdSoeEX0A7XWdDO5UOCb+AdjpeAe1VOiT8Ctq75xXQXqVDwq+gvXteAe1VOiT8Ctq75VXQbqVDwgO0W3kVtFvpcHv4cA8JX5SEL0rCFyXhi5LwRUn4oiR8URK+JP/+/QdKhfUicXLLiQAAAABJRU5ErkJggg==" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 10,
                columns: new[] { "Address", "Email", "Name", "Phone" },
                values: new object[] { "901 Maple St, Los Angeles", "sarah.martinez@gmail.com", "Sarah Martinez", "205-122-4184" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 26);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Olivia Johnson", 6477m, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 2,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Emily Martinez", 5767m, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 3,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Laura Smith", 3504m, new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 4,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Laura Williams", 3881m, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 5,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Sarah Williams", 4165m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 6,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Emily Taylor", 3355m, new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 7,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Laura Garcia", 6827m, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 8,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Olivia Taylor", 6011m, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 9,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "David Jones", 4011m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 10,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Sarah Smith", 7123m, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1,
                columns: new[] { "Amount", "TransactionDate" },
                values: new object[] { 398m, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2,
                columns: new[] { "Amount", "TransactionDate" },
                values: new object[] { 242m, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 2, 498m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 2, 671m, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5,
                columns: new[] { "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 877m, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 3, 315m, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 4, 783m, new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 8,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 4, 528m, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 9,
                columns: new[] { "Amount", "TransactionDate" },
                values: new object[] { 955m, new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 10,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 5, 394m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 11,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 6, 171m, new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 12,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 6, 752m, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 13,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 6, 585m, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 14,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 6, 470m, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 15,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 7, 880m, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 16,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 7, 102m, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 17,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 7, 469m, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 18,
                columns: new[] { "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 782m, new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 19,
                columns: new[] { "Amount", "TransactionDate" },
                values: new object[] { 893m, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 20,
                columns: new[] { "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 110m, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 21,
                columns: new[] { "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 682m, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 22,
                columns: new[] { "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 875m, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 23,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 10, 143m, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 24,
                columns: new[] { "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 98m, new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 1,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "885 Walnut St, San Jose", "olivia.johnson@gmail.com", "Olivia Johnson", "passwordOlivia", "984-957-4129", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAOnSURBVHhe7ZPRCmMhDAX7/z/dXR8KyzIY49XricnAPBVac4Z+vkVKKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKvxfPp+PyxtIFZ4irjQS14enQG+ozpXhKcRJFbkqPI2upBJXhKeRlVUgfHgaNoKnCRuexozoKUKGpwEje4JQ4Wm0W3ybMOFprJ3+oM92+hYhwtNAK3wKfecK30A+PA3zxJ3Q7826G+nwNMiMb0NvmHEnsuFpiBlPQW+ZcRfXhleB3uZxF5LhaQCPatAbPe5AbiU63KMy9N5RVyO1FB08ahTo7aOu5Irw0aAbRlyJzGp06IhRoVtGXEWFPwTdMuIqJJajA0eMDt004gqOr0eHjXgLdJvlCkKGvwm6b8SnVHgB6EbLpxxdkQ6yvBW61fIJFV4EutXyCceWpENGvBW61fIJocLfDt1sOUuFF4JutpzlyJp0gGUW6Paes1R4Meh2yxkqvBh0u+UMFV4Mut1yhhDhs0Eb9Jzh9VXp4ZbZoA16zlDhBaENLL1UeEFoA0svFV4Q2sDSi3z4jNAOll4qvCC0g6WXCi8KbdHTS4UXhbbo6aXCi0Jb9PRS4UWhLXp6qfCi0BY9vVR4UWiLnl4qvCi0RU8vFV4U2qKnlwovCm3R00uFF4W26OmlwgtCO1h6qfCC0A6WXuTDN7NBG1h6qfCC0AaWXiq8ILSBpZcKLwht0HOGI6vS43tmgzboOUOI8M0s0O2WM1R4Meh2yxkqvBh0u+UMxxalA3pmgW7vOUuY8M3boZstZ6nwQtDNlrOECt+8FbrV8glHl6RjLG+FbrV8QoUXgO4c8QnHl6SDLG+DbrR8SsjwzVug20Z8isSCdJjlLdBtlisIG74ZHbppxBXIrEcHjhgVumXEVVT4Q9AtI65Cajk6dMRo0A0jruSK8M0I0LtHXY3cYnS0R1XorR5XI7kUHe5RDXqjxx3I/kVoAI8q0Ns87kI2fIOG8HoKeovXnVwfvvk29IYZdyIdvkGDPHEX9FtP3I18+AYNs8Kn0Heu8A1ChG/QQDv9QZ/t9C3ChP9BY93g24QL36DhInuCkOEbNGBETxE2/A8aM4KnCR++QcMqq8AV4X/QyEoqcVX4HzT6SRW5Mvy/UIg3VOf68P9DkVYZiXThCYrY8wYqfFIqfFIqfFIqfFIqfFIqfFIqfEq+3z8+b1xWzv2W6AAAAABJRU5ErkJggg==" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 2,
                columns: new[] { "Address", "Email", "Name", "Phone" },
                values: new object[] { "831 Pine St, New York", "emily.martinez@gmail.com", "Emily Martinez", "270-232-5422" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 3,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "612 Pine St, San Diego", "laura.smith@gmail.com", "Laura Smith", "passwordLaura", "208-219-2017", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAFTSURBVHhe7dHBCcNAEATByz/pUwwGL1rRVTD/gT6XJOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI96Pfw556fxH8JHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfNTnwn9tWwk/vK2EH95Wwg9vK+GHt5Xww9tK+OFtJfzwthJ+eFsJP7yt9j5jlPBRwkcJHyV8lPBRwkcJHyV80r0PU2FnLFKaa9EAAAAASUVORK5CYII=" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 4,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "773 Highland Ave, Houston", "laura.williams@gmail.com", "Laura Williams", "passwordLaura", "134-482-9758", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAFTSURBVHhe7dHBCcNAEATByz/pUwwGL1rRVTD/gT6XJOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI96Pfw556fxH8JHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfNTnwn9tWwk/vK2EH95Wwg9vK+GHt5Xww9tK+OFtJfzwthJ+eFsJP7yt9j5jlPBRwkcJHyV8lPBRwkcJHyV80r0PU2FnLFKaa9EAAAAASUVORK5CYII=" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 5,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "258 Walnut St, San Diego", "sarah.williams@gmail.com", "Sarah Williams", "passwordSarah", "232-178-7606", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAANoSURBVHhe7ZTRbuMwEAPz/z+dg3AXIBfQsmxLu6SWA8xrveK0fb1NSRy+KA5fFIcvisMXxeGL4vBFcfiiOHxRHL4oDl8Uhy+KwxfF4Yvi8EVx+KI4fFEcvigOXxSHL4rDF8Xhi+LwRXH4ojh8UbYP/3q9brk7W70QBZzpTsi/BgWKUB3JF6AQmSoidTUanUklZK5FQ7OqAP2VaFgF2aG+EA2qJiu0l6ERVWWE8io0nrps0F2ERttFJqiuQWM99S7oZ82QBZpL0Eh3XAX61h1Z2CZ8JOj7V2SA4go0zqhZoFuumI10eAbQXSNmk34BGuVMNtCNI2bi8JNAd56ZSerX0RhnMoPuPTMLqfDsoJvPzMLhJ4Pu7pmFw08G3X1mBjLhlUD398zA4ReA7u+ZgcMvAN3fM4O0RdEAPZVA9/fMIHVRNMKRaqA3HJmBwxdFJnzTzMPhiyIVvmnmIBe+aZ6TviIKO6J5hmz4prmPdPiP5joUq6GYdzVj0CyFIj7VHLN1+G/N/1AtgoKtsjp0C6BIUVaC8rUoSoY7Q/s6FCLbnaB/DQrAoDoSL0DDM6mI1NVodCaVkPx1RaMzqYDm/6l/oNGZZEY6/DdoeBYZ2Sb8LyhApmxsG/4XFCNDFsqE/wVFiZKBsuF/QYFWmo3DH4BizTYThx8ARZtlFg5/ERTviVk4/ANQyDtm4PATQDGvmIHDTwRFHTUah58MijpiNA6/ABR2xEgcfhEo7JmROPwiUNgzI3H4haC4PSMJ/Rp6bE910Jt6RuLwi0HvOjKS8HXRg4/cAfSuIyNx+MWgd/WMgjp8Ux30piMjcfjFoDcdGYnDLwa96chI6MM3lUHvOTKSlFXRo3uqgt7SMxKJ8E1F0Dt6RiITvqkGekPPSNLWRA8/Uwl0f89opMI3FUB3nxlN6pJogBGZQfeOGI1k+CYj6M4RM0hfEA1xRRbQbaNmIB/+YybonlGzoPiTQYPcNRL0/StmQhG+gYZ56grQd+6aCU34BhpnpndAP2eG2VCFb6CRdpMBuvANNNYuskAZvoFGU5cJ2vANNJ6qbFCHb6ARlWSFPvwHNCq7zMiE/4AGZlMBufAf0ODZKiEb/hsUIVJFtgj/C4oz0x3YMnwPFPLInSkX3vzF4Yvi8EVx+KI4fFEcvigOX5L3+w+v/DGd3p4PCQAAAABJRU5ErkJggg==" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 6,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "736 Cedar Ave, San Jose", "emily.taylor@gmail.com", "Emily Taylor", "passwordEmily", "534-461-7875", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAFxSURBVHhe7dEBbQRAEMSw50+6JVHd7De2FAT5/JBkfJTxUcZHGR9lfJTxUcZHGR9lfJTxUcZHGR9lfJTxUcZHGR9lfJTxUcZHGR9lfJTxUcZHGR9lfJTxUfPxn88n34LxB1ow/kALxh9owfgDLRh/oAXjD7Rg/IEWjD/QgvEHWvi68fwN46OMjzI+yvgo46OMjzI+yvgo46OMjzI+yvgo46OMjzI+yvgo46OMjzI+yvgo46OMjzI+yvgo46OMjzI+6uvG/5fWjB+1ZvyoNeNHrRk/as34UWvGj1ozftSa8aPWjB+1Zvyota8bz98wPsr4KOOjjI8yPsr4KOOjjI8yPsr4KOOjjI8yPsr4KOOjjI8yPsr4KOOjjI8yPsr4KOOjjI8yPsr4KOOjjI8yPsr4qK8b/597yfhDvWT8oV4y/lAvGX+ol4w/1EvGH+ol4w/1kvGHesn4Q700H8+G8VHGRxkfZXyU8VHGRxkfZXzSz88vY/KCTCRBTNEAAAAASUVORK5CYII=" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 7,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "135 Walnut St, Houston", "laura.garcia@gmail.com", "Laura Garcia", "passwordLaura", "418-563-1418", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAFTSURBVHhe7dHBCcNAEATByz/pUwwGL1rRVTD/gT6XJOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI96Pfw556fxH8JHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfNTnwn9tWwk/vK2EH95Wwg9vK+GHt5Xww9tK+OFtJfzwthJ+eFsJP7yt9j5jlPBRwkcJHyV8lPBRwkcJHyV80r0PU2FnLFKaa9EAAAAASUVORK5CYII=" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 8,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "309 Walnut St, Phoenix", "olivia.taylor@gmail.com", "Olivia Taylor", "passwordOlivia", "994-465-6009", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAOnSURBVHhe7ZPRCmMhDAX7/z/dXR8KyzIY49XricnAPBVac4Z+vkVKKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKvxfPp+PyxtIFZ4irjQS14enQG+ozpXhKcRJFbkqPI2upBJXhKeRlVUgfHgaNoKnCRuexozoKUKGpwEje4JQ4Wm0W3ybMOFprJ3+oM92+hYhwtNAK3wKfecK30A+PA3zxJ3Q7826G+nwNMiMb0NvmHEnsuFpiBlPQW+ZcRfXhleB3uZxF5LhaQCPatAbPe5AbiU63KMy9N5RVyO1FB08ahTo7aOu5Irw0aAbRlyJzGp06IhRoVtGXEWFPwTdMuIqJJajA0eMDt004gqOr0eHjXgLdJvlCkKGvwm6b8SnVHgB6EbLpxxdkQ6yvBW61fIJFV4EutXyCceWpENGvBW61fIJocLfDt1sOUuFF4JutpzlyJp0gGUW6Paes1R4Meh2yxkqvBh0u+UMFV4Mut1yhhDhs0Eb9Jzh9VXp4ZbZoA16zlDhBaENLL1UeEFoA0svFV4Q2sDSi3z4jNAOll4qvCC0g6WXCi8KbdHTS4UXhbbo6aXCi0Jb9PRS4UWhLXp6qfCi0BY9vVR4UWiLnl4qvCi0RU8vFV4U2qKnlwovCm3R00uFF4W26OmlwgtCO1h6qfCC0A6WXuTDN7NBG1h6qfCC0AaWXiq8ILSBpZcKLwht0HOGI6vS43tmgzboOUOI8M0s0O2WM1R4Meh2yxkqvBh0u+UMxxalA3pmgW7vOUuY8M3boZstZ6nwQtDNlrOECt+8FbrV8glHl6RjLG+FbrV8QoUXgO4c8QnHl6SDLG+DbrR8SsjwzVug20Z8isSCdJjlLdBtlisIG74ZHbppxBXIrEcHjhgVumXEVVT4Q9AtI65Cajk6dMRo0A0jruSK8M0I0LtHXY3cYnS0R1XorR5XI7kUHe5RDXqjxx3I/kVoAI8q0Ns87kI2fIOG8HoKeovXnVwfvvk29IYZdyIdvkGDPHEX9FtP3I18+AYNs8Kn0Heu8A1ChG/QQDv9QZ/t9C3ChP9BY93g24QL36DhInuCkOEbNGBETxE2/A8aM4KnCR++QcMqq8AV4X/QyEoqcVX4HzT6SRW5Mvy/UIg3VOf68P9DkVYZiXThCYrY8wYqfFIqfFIqfFIqfFIqfFIqfFIqfEq+3z8+b1xWzv2W6AAAAABJRU5ErkJggg==" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 9,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "172 Elm St, Dallas", "david.jones@gmail.com", "David Jones", "passwordDavid", "719-393-5470", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAK1SURBVHhe7dHRDcMwDAPR7r90uwBhOY0oOdE9gL+Jhft8MRLhhyL8UIQfivBDEX4owg9F+KEIPxThhyL8UIQfivBDEX4owg9F+KEIPxThhyL8UIQfivBDEX4owg9F+KEIPxThhyL8UO3hP5/P0Xsrwv+xNyB8wp6I8Il7EsIb9gSEN+9UhC/YiQhfuJMQvninIHzDTvC48A7qPxXrRPgN6h1Z60L4i9Sb7q4D4W9Q7/tnHQifQL3z6qoRPpF675VVInwy9eYrq0J4A/Xu3VUhvIl6++4qEN5IvX9nFQhvpm7YmRvhC6g7orkRvoC6Y2dOhC+ibonmRPgi6paduRC+kLonmgvhC6l7orkQvpi6aTUXwhdTN0VzIHwxdVM0B8I3UHet5kD4Buqu1RwI30DdFS0b4Ruou6JlI3wDdVe0bIRvom5bLRvhm6jbVstG+CbqttWyEb6Jum21bIRvom5bLRvhm6jbVstG+CbqtmiZCN9E3RYtE+GbqNuiZSJ8E3VbtEyEb6Jui5aJ8E3UbdEyEb6Jui1aJsI3Ubetlo3wTdRtq2UjfBN122rZCN9E3bZaNsI3Ubetlo3wTdRtq2UjfBN122rZCN9A3RUtG+EbqLuiZSN8A3XXag6Eb6DuWs2B8MXUTdEcCF9M3RTNgfDF1E3RHAhfSN0TzYXwhdQ90VwIX0jdE82F8EXULdGcCF9E3RLNifAF1B3R3Ahvpm7YmRvhzdQNO3MjvJF6/84qEN5EvX13FQhvoN69uyqET6bevLtKhE+k3ntllQifQL3z6qoR/gb1vn/WgfAXqTfdWRfCB9QbstZpdHj1/ap1e1z4N+wEhC/eKQhftNMQvmAnIrxxJyO8YU9A+MQ9CeFv7qkIf3FvQfhgb/Xey7BE+KEIPxThhyL8UIQfivBDEX4owo/0/f4ARZg+dAE/yWkAAAAASUVORK5CYII=" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 10,
                columns: new[] { "Address", "Email", "Name", "Phone" },
                values: new object[] { "431 Birch St, Los Angeles", "sarah.smith@gmail.com", "Sarah Smith", "981-201-3821" });
        }
    }
}
