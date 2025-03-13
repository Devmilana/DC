﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankDataService.Migrations
{
    public partial class IsAdminImpl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "UserProfiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Robert Martinez", 2213m, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 2,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "David Garcia", 10870m, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 3,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Laura Martinez", 4221m, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 4,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Olivia Davis", 6723m, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 5,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Laura Williams", 8577m, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 6,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Laura Brown", 3963m, new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 7,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "John Williams", 8772m, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 8,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Michael Miller", 3724m, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 9,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Michael Martinez", 7712m, new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 10,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Robert Brown", 2394m, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1,
                columns: new[] { "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 241m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2,
                columns: new[] { "Amount", "TransactionDate" },
                values: new object[] { 857m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 2, 713m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 2, 732m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5,
                columns: new[] { "Amount", "TransactionDate" },
                values: new object[] { 991m, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 2, 649m, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7,
                columns: new[] { "Amount", "TransactionDate" },
                values: new object[] { 83m, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 8,
                columns: new[] { "Amount", "TransactionDate" },
                values: new object[] { 143m, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 9,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 3, 704m, new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 10,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 3, 186m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 11,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 4, 853m, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 12,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 4, 696m, new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 13,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 4, 742m, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 14,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 4, 464m, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 15,
                columns: new[] { "AccountId", "Amount" },
                values: new object[] { 5, 158m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 16,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 5, 958m, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 17,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 5, 438m, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 18,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 5, 57m, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 19,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 6, 255m, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 20,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 6, 274m, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 21,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 7, 227m, new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 22,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 7, 248m, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 23,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 8, 269m, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 24,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 9, 856m, new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 25, 10, 978m, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 26, 10, 170m, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 1,
                columns: new[] { "Address", "Email", "IsAdmin", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "518 Main St, Phoenix", "robert.martinez@gmail.com", true, "Robert Martinez", "passwordRobert", "944-735-1537", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAKwSURBVHhe7dHRkcMwDAPR9N90rgGMaPsEUA73zeDbovfzxUiEH4rwQxF+KMIPRfihCD8U4Yci/FCEH4rwQxF+KMIPRfihCD8U4Yci/FCEH4rwQxF+KMIPRfihCD8U4Yci/FCEH4rwQ7WH/3w+P7W3ILx5pyJ8cCchfMNOQPjGdSJ887oQ/oB1IPwhSyP8QUsi/EFLel34E6l3Pl0K4TdTb767BMIbqHffWQLhjdT7r86N8GbqhitzI3yAuqOaG+FD1C3VnAgfom6p5kT4IHXPak6ED1L3VHMhfJC6p5oL4cPUTau5ED5M3bSaC+HD1E2ruRA+TN20mgvhw9RNq7kQPkzdtJoL4cPUTau5ED5M3bSaC+GD1D3VXAgfpO6p5kL4IHXPak6ED1L3rOZE+BB1SzUnwgeoO6q5ET5A3VHNjfBm6oYrcyO8iXr71SUQfjP15jtLIfwG6p1Pl0L4m9Sbdi3pdeF/dWmEP2AdCN+8LoRvWjfCN+wEhA/uJIQP7ESEN+10hN+8tyC8aad7XXgX9a0dOxXhC+oNT3Yawt+g3nNnJyH8TepNd3YKwj+k3nZ1JyD8P6j3XdkJCP9P6o1X1o3wG6h3Xlknwm+i3lqtE+E3Uu+t1oXwm6k3r9aF8JupN1frQHgD9e7VOhDeQL27WhrhTdTbV0sjvIl6e7Ukwpuot1dLIryRev9qSYQ3Uu+vlkJ4I/X+aimEN1M3rJZCeDN1Q7UEwpupG6olED5A3VHNjfAB6o5qboQPUHdUcyN8iLqlmhPhQ9Qt1ZwIH6TuWc2J8EHqnmouhA9S91RzIXyYumk1F8KHqZuqORA+TN1UzYHwDdRd1XYjfAN1V7XdCN9A3VVtN8I3UbdV24nwTdRt1Xb6nT+JWwg/FOGHIvxQhB+K8EMRfijCD0X4kb7fP15QBKB5xkTEAAAAAElFTkSuQmCC" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 2,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "958 Cherry St, Los Angeles", "david.garcia@gmail.com", "David Garcia", "passwordDavid", "729-604-8121", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAK1SURBVHhe7dHRDcMwDAPR7r90uwBhOY0oOdE9gL+Jhft8MRLhhyL8UIQfivBDEX4owg9F+KEIPxThhyL8UIQfivBDEX4owg9F+KEIPxThhyL8UIQfivBDEX4owg9F+KEIPxThhyL8UO3hP5/P0Xsrwv+xNyB8wp6I8Il7EsIb9gSEN+9UhC/YiQhfuJMQvninIHzDTvC48A7qPxXrRPgN6h1Z60L4i9Sb7q4D4W9Q7/tnHQifQL3z6qoRPpF675VVInwy9eYrq0J4A/Xu3VUhvIl6++4qEN5IvX9nFQhvpm7YmRvhC6g7orkRvoC6Y2dOhC+ibonmRPgi6paduRC+kLonmgvhC6l7orkQvpi6aTUXwhdTN0VzIHwxdVM0B8I3UHet5kD4Buqu1RwI30DdFS0b4Ruou6JlI3wDdVe0bIRvom5bLRvhm6jbVstG+CbqttWyEb6Jum21bIRvom5bLRvhm6jbVstG+CbqtmiZCN9E3RYtE+GbqNuiZSJ8E3VbtEyEb6Jui5aJ8E3UbdEyEb6Jui1aJsI3Ubetlo3wTdRtq2UjfBN122rZCN9E3bZaNsI3Ubetlo3wTdRtq2UjfBN122rZCN9A3RUtG+EbqLuiZSN8A3XXag6Eb6DuWs2B8MXUTdEcCF9M3RTNgfDF1E3RHAhfSN0TzYXwhdQ90VwIX0jdE82F8EXULdGcCF9E3RLNifAF1B3R3Ahvpm7YmRvhzdQNO3MjvJF6/84qEN5EvX13FQhvoN69uyqET6bevLtKhE+k3ntllQifQL3z6qoR/gb1vn/WgfAXqTfdWRfCB9QbstZpdHj1/ap1e1z4N+wEhC/eKQhftNMQvmAnIrxxJyO8YU9A+MQ9CeFv7qkIf3FvQfhgb/Xey7BE+KEIPxThhyL8UIQfivBDEX4owo/0/f4ARZg+dAE/yWkAAAAASUVORK5CYII=" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 3,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "822 Walnut St, Chicago", "laura.martinez@gmail.com", "Laura Martinez", "passwordLaura", "738-946-6749", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAFTSURBVHhe7dHBCcNAEATByz/pUwwGL1rRVTD/gT6XJOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI96Pfw556fxH8JHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfNTnwn9tWwk/vK2EH95Wwg9vK+GHt5Xww9tK+OFtJfzwthJ+eFsJP7yt9j5jlPBRwkcJHyV8lPBRwkcJHyV80r0PU2FnLFKaa9EAAAAASUVORK5CYII=" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 4,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "273 Pine St, Houston", "olivia.davis@gmail.com", "Olivia Davis", "passwordOlivia", "289-709-2983", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAOnSURBVHhe7ZPRCmMhDAX7/z/dXR8KyzIY49XricnAPBVac4Z+vkVKKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKvxfPp+PyxtIFZ4irjQS14enQG+ozpXhKcRJFbkqPI2upBJXhKeRlVUgfHgaNoKnCRuexozoKUKGpwEje4JQ4Wm0W3ybMOFprJ3+oM92+hYhwtNAK3wKfecK30A+PA3zxJ3Q7826G+nwNMiMb0NvmHEnsuFpiBlPQW+ZcRfXhleB3uZxF5LhaQCPatAbPe5AbiU63KMy9N5RVyO1FB08ahTo7aOu5Irw0aAbRlyJzGp06IhRoVtGXEWFPwTdMuIqJJajA0eMDt004gqOr0eHjXgLdJvlCkKGvwm6b8SnVHgB6EbLpxxdkQ6yvBW61fIJFV4EutXyCceWpENGvBW61fIJocLfDt1sOUuFF4JutpzlyJp0gGUW6Paes1R4Meh2yxkqvBh0u+UMFV4Mut1yhhDhs0Eb9Jzh9VXp4ZbZoA16zlDhBaENLL1UeEFoA0svFV4Q2sDSi3z4jNAOll4qvCC0g6WXCi8KbdHTS4UXhbbo6aXCi0Jb9PRS4UWhLXp6qfCi0BY9vVR4UWiLnl4qvCi0RU8vFV4U2qKnlwovCm3R00uFF4W26OmlwgtCO1h6qfCC0A6WXuTDN7NBG1h6qfCC0AaWXiq8ILSBpZcKLwht0HOGI6vS43tmgzboOUOI8M0s0O2WM1R4Meh2yxkqvBh0u+UMxxalA3pmgW7vOUuY8M3boZstZ6nwQtDNlrOECt+8FbrV8glHl6RjLG+FbrV8QoUXgO4c8QnHl6SDLG+DbrR8SsjwzVug20Z8isSCdJjlLdBtlisIG74ZHbppxBXIrEcHjhgVumXEVVT4Q9AtI65Cajk6dMRo0A0jruSK8M0I0LtHXY3cYnS0R1XorR5XI7kUHe5RDXqjxx3I/kVoAI8q0Ns87kI2fIOG8HoKeovXnVwfvvk29IYZdyIdvkGDPHEX9FtP3I18+AYNs8Kn0Heu8A1ChG/QQDv9QZ/t9C3ChP9BY93g24QL36DhInuCkOEbNGBETxE2/A8aM4KnCR++QcMqq8AV4X/QyEoqcVX4HzT6SRW5Mvy/UIg3VOf68P9DkVYZiXThCYrY8wYqfFIqfFIqfFIqfFIqfFIqfFIqfEq+3z8+b1xWzv2W6AAAAABJRU5ErkJggg==" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 5,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "850 Cedar Ave, Philadelphia", "laura.williams@gmail.com", "Laura Williams", "passwordLaura", "625-304-9983", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAFTSURBVHhe7dHBCcNAEATByz/pUwwGL1rRVTD/gT6XJOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI96Pfw556fxH8JHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfNTnwn9tWwk/vK2EH95Wwg9vK+GHt5Xww9tK+OFtJfzwthJ+eFsJP7yt9j5jlPBRwkcJHyV8lPBRwkcJHyV80r0PU2FnLFKaa9EAAAAASUVORK5CYII=" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 6,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "498 Main St, San Antonio", "laura.brown@gmail.com", "Laura Brown", "passwordLaura", "253-145-4593", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAFTSURBVHhe7dHBCcNAEATByz/pUwwGL1rRVTD/gT6XJOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI96Pfw556fxH8JHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfNTnwn9tWwk/vK2EH95Wwg9vK+GHt5Xww9tK+OFtJfzwthJ+eFsJP7yt9j5jlPBRwkcJHyV8lPBRwkcJHyV80r0PU2FnLFKaa9EAAAAASUVORK5CYII=" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 7,
                columns: new[] { "Address", "Email", "Name", "Phone" },
                values: new object[] { "115 Maple St, Philadelphia", "john.williams@gmail.com", "John Williams", "278-549-9807" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 8,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "722 Highland Ave, Houston", "michael.miller@gmail.com", "Michael Miller", "passwordMichael", "282-947-9422", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAR5SURBVHhe7ZHRiq0wEAT3/3/63g2cBZFqbWOiR6cL6slkJlI//0JJEr4oCV+UhC9Kwhcl4YuS8EVJ+KIkfFESvigJX5SEL0rCFyXhi5LwRUn4oiR8URK+KAlflIQvSsIXJeGLkvBFSfiiJHxREr4oCV+U28P//PwM8Q3Qf/XokPBfAv1Trw6vCd98MvQ/vTok/JdA/9OrQ8J/AfQvZ3R4VfjmE6H/OKNDwn8B9B9ndEj4m6F/OKvD68I3nwS9/6wOCX8z9P6zOiT8jdDbR+jwyvDNJ0DvHqFDwt8IvXuEDgl/E/TmUTo8KnzP+W+F3qvsOb9Hwt8EvVfZc36PhL8BeuuWR+84PC58g74pvxF6p/IP+qZ0SPgboHcq/6BvSoeEvwF6p/IP+qZ0eGT4Bn1XfhP0PuUS+q50SPiLofcpl9B3pUPCXwy9T7mEvisdHhu+QWeU3wC9S7mGzigdEv5C6F3KNXRG6ZDwF0LvIgk6p3R4dPgGnSPvht6kJOic0qFM+Oad0HuUBJ1TOiT8RdB7SAWdVTo8PnyDzpJ3QW9RKuis0qFU+OYd0DuUCjqrdEj4C6B3kFvQeaXDK8I36Dx5NfQG5RZ0XulQLnzzSmi/cgs6r3RI+MnQfnIPuqN0eE34Bt0hr4J2K/egO0qHkuGbV0B7lXvQHaVDwk+E9pIOdE/p8KrwDbpHzoZ2Kh3ontKhbPjmTGif0oHuKR0SfhK0j3Shu0qH14Vv0F1yFrRL6UJ3lQ6lwzdnQHuULnRX6ZDwE6A95BHovtLhleEbdJ8cDe1QHoHuKx3Kh2+OhOYrj0D3lQ4J/+tIaD55FJqhdHht+AbNIEdBs5VHoRlKh4T/OAKaqzwKzVA6JPzHEdBcsgeao3R4dfgGzSHPQjOVPdAcpUPCLzwDzVP2QHOUDgm/8Aw0j+yFZikdXh++QbPIXmiWsheapXRI+JU90BxlLzRL6ZDwK3ugOeQZaJ7SoUT4Bs0jj0IzlGegeUqHhAePQPeVZ6B5SoeEB49A98mz0EylQ5nwDZpJutBd5VloptIh4YUOdE95FpqpdEh4oQPdI0dAc5UOpcI3aC65B91RjoDmKh0SfsMt6LxyBDRX6ZDwG25B58lR0GylQ7nwDZpNKuischQ0W+mQ8Bsq6KxyFDRb6ZDwOxJ0jhwJzVc6lAzfoPnkGjqjHAnNVzok/I5r6IxyJDRf6ZDwhkvoOzka2qF0KBu+QTvIJfSdHA3tUDokvOEf9E05GtqhdEh40yPnZ0B7lA6lwzdoD3n07Ghoj9Ih4WHPWWdAe5QOCQ97zjgL2qV0KB++Qbt6nQXtUjok/C+0q9dZ0C6lQ8L/Qrt6nAntUzok/Afad9SZ0D6lQ8J/oH1HnQntUzok/Afad8TZ0E6lQ8IvoJ2us6GdSoeEX0A7XWdDO5UOCb+AdjpeAe1VOiT8Ctq75xXQXqVDwq+gvXteAe1VOiT8Ctq75VXQbqVDwgO0W3kVtFvpcHv4cA8JX5SEL0rCFyXhi5LwRUn4oiR8URK+JP/+/QdKhfUicXLLiQAAAABJRU5ErkJggg==" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 9,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "258 Maple St, Los Angeles", "michael.martinez@gmail.com", "Michael Martinez", "passwordMichael", "238-729-6015", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAR5SURBVHhe7ZHRiq0wEAT3/3/63g2cBZFqbWOiR6cL6slkJlI//0JJEr4oCV+UhC9Kwhcl4YuS8EVJ+KIkfFESvigJX5SEL0rCFyXhi5LwRUn4oiR8URK+KAlflIQvSsIXJeGLkvBFSfiiJHxREr4oCV+U28P//PwM8Q3Qf/XokPBfAv1Trw6vCd98MvQ/vTok/JdA/9OrQ8J/AfQvZ3R4VfjmE6H/OKNDwn8B9B9ndEj4m6F/OKvD68I3nwS9/6wOCX8z9P6zOiT8jdDbR+jwyvDNJ0DvHqFDwt8IvXuEDgl/E/TmUTo8KnzP+W+F3qvsOb9Hwt8EvVfZc36PhL8BeuuWR+84PC58g74pvxF6p/IP+qZ0SPgboHcq/6BvSoeEvwF6p/IP+qZ0eGT4Bn1XfhP0PuUS+q50SPiLofcpl9B3pUPCXwy9T7mEvisdHhu+QWeU3wC9S7mGzigdEv5C6F3KNXRG6ZDwF0LvIgk6p3R4dPgGnSPvht6kJOic0qFM+Oad0HuUBJ1TOiT8RdB7SAWdVTo8PnyDzpJ3QW9RKuis0qFU+OYd0DuUCjqrdEj4C6B3kFvQeaXDK8I36Dx5NfQG5RZ0XulQLnzzSmi/cgs6r3RI+MnQfnIPuqN0eE34Bt0hr4J2K/egO0qHkuGbV0B7lXvQHaVDwk+E9pIOdE/p8KrwDbpHzoZ2Kh3ontKhbPjmTGif0oHuKR0SfhK0j3Shu0qH14Vv0F1yFrRL6UJ3lQ6lwzdnQHuULnRX6ZDwE6A95BHovtLhleEbdJ8cDe1QHoHuKx3Kh2+OhOYrj0D3lQ4J/+tIaD55FJqhdHht+AbNIEdBs5VHoRlKh4T/OAKaqzwKzVA6JPzHEdBcsgeao3R4dfgGzSHPQjOVPdAcpUPCLzwDzVP2QHOUDgm/8Aw0j+yFZikdXh++QbPIXmiWsheapXRI+JU90BxlLzRL6ZDwK3ugOeQZaJ7SoUT4Bs0jj0IzlGegeUqHhAePQPeVZ6B5SoeEB49A98mz0EylQ5nwDZpJutBd5VloptIh4YUOdE95FpqpdEh4oQPdI0dAc5UOpcI3aC65B91RjoDmKh0SfsMt6LxyBDRX6ZDwG25B58lR0GylQ7nwDZpNKuischQ0W+mQ8Bsq6KxyFDRb6ZDwOxJ0jhwJzVc6lAzfoPnkGjqjHAnNVzok/I5r6IxyJDRf6ZDwhkvoOzka2qF0KBu+QTvIJfSdHA3tUDokvOEf9E05GtqhdEh40yPnZ0B7lA6lwzdoD3n07Ghoj9Ih4WHPWWdAe5QOCQ97zjgL2qV0KB++Qbt6nQXtUjok/C+0q9dZ0C6lQ8L/Qrt6nAntUzok/Afad9SZ0D6lQ8J/oH1HnQntUzok/Afad8TZ0E6lQ8IvoJ2us6GdSoeEX0A7XWdDO5UOCb+AdjpeAe1VOiT8Ctq75xXQXqVDwq+gvXteAe1VOiT8Ctq75VXQbqVDwgO0W3kVtFvpcHv4cA8JX5SEL0rCFyXhi5LwRUn4oiR8URK+JP/+/QdKhfUicXLLiQAAAABJRU5ErkJggg==" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 10,
                columns: new[] { "Address", "Email", "Name", "Phone" },
                values: new object[] { "990 Cedar Ave, New York", "robert.brown@gmail.com", "Robert Brown", "282-976-2895" });
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

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "UserProfiles");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Laura Johnson", 6800m, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 2,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Laura Miller", 5473m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 3,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "James Smith", 3909m, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 4,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "James Martinez", 7354m, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 5,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Olivia Johnson", 9272m, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 6,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "David Smith", 3644m, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 7,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "John Brown", 8665m, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 8,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Sarah Smith", 3624m, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 9,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "James Garcia", 6524m, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 10,
                columns: new[] { "AccountHolderName", "Balance", "CreatedAt" },
                values: new object[] { "Robert Williams", 7395m, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1,
                columns: new[] { "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 435m, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2,
                columns: new[] { "Amount", "TransactionDate" },
                values: new object[] { 346m, new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 1, 640m, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 1, 190m, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5,
                columns: new[] { "Amount", "TransactionDate" },
                values: new object[] { 692m, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 3, 524m, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7,
                columns: new[] { "Amount", "TransactionDate" },
                values: new object[] { 93m, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 8,
                columns: new[] { "Amount", "TransactionDate" },
                values: new object[] { 533m, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 9,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 4, 178m, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 10,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 4, 668m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 11,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 5, 469m, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 12,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 5, 639m, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 13,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 5, 105m, new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 14,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 5, 115m, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 15,
                columns: new[] { "AccountId", "Amount" },
                values: new object[] { 6, 883m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 16,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 7, 461m, new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 17,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 7, 996m, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 18,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 8, 560m, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 19,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 9, 434m, new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 20,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 9, 763m, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "Deposit" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 21,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 9, 783m, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 22,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 9, 601m, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 23,
                columns: new[] { "AccountId", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 10, 899m, new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Withdrawal" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 24,
                columns: new[] { "AccountId", "Amount", "TransactionDate" },
                values: new object[] { 10, 297m, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 1,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "625 Walnut St, Dallas", "laura.johnson@gmail.com", "Laura Johnson", "passwordLaura", "593-708-7187", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAFTSURBVHhe7dHBCcNAEATByz/pUwwGL1rRVTD/gT6XJOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI96Pfw556fxH8JHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfNTnwn9tWwk/vK2EH95Wwg9vK+GHt5Xww9tK+OFtJfzwthJ+eFsJP7yt9j5jlPBRwkcJHyV8lPBRwkcJHyV80r0PU2FnLFKaa9EAAAAASUVORK5CYII=" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 2,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "942 Walnut St, Dallas", "laura.miller@gmail.com", "Laura Miller", "passwordLaura", "834-533-3899", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAFTSURBVHhe7dHBCcNAEATByz/pUwwGL1rRVTD/gT6XJOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI8SPkr4KOGjhI96Pfw556fxH8JHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfJTwUcJHCR8lfNTnwn9tWwk/vK2EH95Wwg9vK+GHt5Xww9tK+OFtJfzwthJ+eFsJP7yt9j5jlPBRwkcJHyV8lPBRwkcJHyV80r0PU2FnLFKaa9EAAAAASUVORK5CYII=" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 3,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "347 Cherry St, New York", "james.smith@gmail.com", "James Smith", "passwordJames", "557-947-8180", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAIvSURBVHhe7dFBbsJQEARR7n9pIlaJopHtTsD+rq4n9RKs+fV4qpLhSxm+lOFLGb6U4UsZvpThSxm+lOFLGb6U4UsZvpThSxm+lOFLGb6U4UsZvpThSxm+lOFLGb6U4UsZvpThSxm+VHX4x+MRjcTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFITrlmesStnWX69tZIDB+MxPDBSAwfjKQ2/PTdrdEY/uBolgz/2qdN39wajeEPjsbwB0dz2kXTY27tk6bv7Y1m2fCvfcr0ra0RGf7AiJYO/9q7Td/YG9GpV02PemTvMv333qhuEf61/5r+88ioTr9setyj+4vpf5JR3Sr8z+2ZfpOO7JLrpkdecWSXXTc99EqjM/ywBpdeOT36Cmtw+ZXTw1+5FktcOgU4e22WungKcsYaLXf1FOaTa7Xs5VOkd67dLV5gCveX6dstX2OK+nva5guVMnwpw5cyfCnDlzJ8KcNXej6/ADqIE4A0DE9uAAAAAElFTkSuQmCC" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 4,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "383 Birch St, Los Angeles", "james.martinez@gmail.com", "James Martinez", "passwordJames", "189-196-7385", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAIvSURBVHhe7dFBbsJQEARR7n9pIlaJopHtTsD+rq4n9RKs+fV4qpLhSxm+lOFLGb6U4UsZvpThSxm+lOFLGb6U4UsZvpThSxm+lOFLGb6U4UsZvpThSxm+lOFLGb6U4UsZvpThSxm+VHX4x+MRjcTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFITrlmesStnWX69tZIDB+MxPDBSAwfjKQ2/PTdrdEY/uBolgz/2qdN39wajeEPjsbwB0dz2kXTY27tk6bv7Y1m2fCvfcr0ra0RGf7AiJYO/9q7Td/YG9GpV02PemTvMv333qhuEf61/5r+88ioTr9setyj+4vpf5JR3Sr8z+2ZfpOO7JLrpkdecWSXXTc99EqjM/ywBpdeOT36Cmtw+ZXTw1+5FktcOgU4e22WungKcsYaLXf1FOaTa7Xs5VOkd67dLV5gCveX6dstX2OK+nva5guVMnwpw5cyfCnDlzJ8KcNXej6/ADqIE4A0DE9uAAAAAElFTkSuQmCC" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 5,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "122 Cedar Ave, New York", "olivia.johnson@gmail.com", "Olivia Johnson", "passwordOlivia", "960-646-4831", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAOnSURBVHhe7ZPRCmMhDAX7/z/dXR8KyzIY49XricnAPBVac4Z+vkVKKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKnxSKvxfPp+PyxtIFZ4irjQS14enQG+ozpXhKcRJFbkqPI2upBJXhKeRlVUgfHgaNoKnCRuexozoKUKGpwEje4JQ4Wm0W3ybMOFprJ3+oM92+hYhwtNAK3wKfecK30A+PA3zxJ3Q7826G+nwNMiMb0NvmHEnsuFpiBlPQW+ZcRfXhleB3uZxF5LhaQCPatAbPe5AbiU63KMy9N5RVyO1FB08ahTo7aOu5Irw0aAbRlyJzGp06IhRoVtGXEWFPwTdMuIqJJajA0eMDt004gqOr0eHjXgLdJvlCkKGvwm6b8SnVHgB6EbLpxxdkQ6yvBW61fIJFV4EutXyCceWpENGvBW61fIJocLfDt1sOUuFF4JutpzlyJp0gGUW6Paes1R4Meh2yxkqvBh0u+UMFV4Mut1yhhDhs0Eb9Jzh9VXp4ZbZoA16zlDhBaENLL1UeEFoA0svFV4Q2sDSi3z4jNAOll4qvCC0g6WXCi8KbdHTS4UXhbbo6aXCi0Jb9PRS4UWhLXp6qfCi0BY9vVR4UWiLnl4qvCi0RU8vFV4U2qKnlwovCm3R00uFF4W26OmlwgtCO1h6qfCC0A6WXuTDN7NBG1h6qfCC0AaWXiq8ILSBpZcKLwht0HOGI6vS43tmgzboOUOI8M0s0O2WM1R4Meh2yxkqvBh0u+UMxxalA3pmgW7vOUuY8M3boZstZ6nwQtDNlrOECt+8FbrV8glHl6RjLG+FbrV8QoUXgO4c8QnHl6SDLG+DbrR8SsjwzVug20Z8isSCdJjlLdBtlisIG74ZHbppxBXIrEcHjhgVumXEVVT4Q9AtI65Cajk6dMRo0A0jruSK8M0I0LtHXY3cYnS0R1XorR5XI7kUHe5RDXqjxx3I/kVoAI8q0Ns87kI2fIOG8HoKeovXnVwfvvk29IYZdyIdvkGDPHEX9FtP3I18+AYNs8Kn0Heu8A1ChG/QQDv9QZ/t9C3ChP9BY93g24QL36DhInuCkOEbNGBETxE2/A8aM4KnCR++QcMqq8AV4X/QyEoqcVX4HzT6SRW5Mvy/UIg3VOf68P9DkVYZiXThCYrY8wYqfFIqfFIqfFIqfFIqfFIqfFIqfEq+3z8+b1xWzv2W6AAAAABJRU5ErkJggg==" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 6,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "982 Walnut St, Houston", "david.smith@gmail.com", "David Smith", "passwordDavid", "850-645-1676", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAK1SURBVHhe7dHRDcMwDAPR7r90uwBhOY0oOdE9gL+Jhft8MRLhhyL8UIQfivBDEX4owg9F+KEIPxThhyL8UIQfivBDEX4owg9F+KEIPxThhyL8UIQfivBDEX4owg9F+KEIPxThhyL8UO3hP5/P0Xsrwv+xNyB8wp6I8Il7EsIb9gSEN+9UhC/YiQhfuJMQvninIHzDTvC48A7qPxXrRPgN6h1Z60L4i9Sb7q4D4W9Q7/tnHQifQL3z6qoRPpF675VVInwy9eYrq0J4A/Xu3VUhvIl6++4qEN5IvX9nFQhvpm7YmRvhC6g7orkRvoC6Y2dOhC+ibonmRPgi6paduRC+kLonmgvhC6l7orkQvpi6aTUXwhdTN0VzIHwxdVM0B8I3UHet5kD4Buqu1RwI30DdFS0b4Ruou6JlI3wDdVe0bIRvom5bLRvhm6jbVstG+CbqttWyEb6Jum21bIRvom5bLRvhm6jbVstG+CbqtmiZCN9E3RYtE+GbqNuiZSJ8E3VbtEyEb6Jui5aJ8E3UbdEyEb6Jui1aJsI3Ubetlo3wTdRtq2UjfBN122rZCN9E3bZaNsI3Ubetlo3wTdRtq2UjfBN122rZCN9A3RUtG+EbqLuiZSN8A3XXag6Eb6DuWs2B8MXUTdEcCF9M3RTNgfDF1E3RHAhfSN0TzYXwhdQ90VwIX0jdE82F8EXULdGcCF9E3RLNifAF1B3R3Ahvpm7YmRvhzdQNO3MjvJF6/84qEN5EvX13FQhvoN69uyqET6bevLtKhE+k3ntllQifQL3z6qoR/gb1vn/WgfAXqTfdWRfCB9QbstZpdHj1/ap1e1z4N+wEhC/eKQhftNMQvmAnIrxxJyO8YU9A+MQ9CeFv7qkIf3FvQfhgb/Xey7BE+KEIPxThhyL8UIQfivBDEX4owo/0/f4ARZg+dAE/yWkAAAAASUVORK5CYII=" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 7,
                columns: new[] { "Address", "Email", "Name", "Phone" },
                values: new object[] { "345 Cherry St, Dallas", "john.brown@gmail.com", "John Brown", "196-966-3092" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 8,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "501 Highland Ave, Philadelphia", "sarah.smith@gmail.com", "Sarah Smith", "passwordSarah", "495-467-1849", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAANoSURBVHhe7ZTRbuMwEAPz/z+dg3AXIBfQsmxLu6SWA8xrveK0fb1NSRy+KA5fFIcvisMXxeGL4vBFcfiiOHxRHL4oDl8Uhy+KwxfF4Yvi8EVx+KI4fFEcvigOXxSHL4rDF8Xhi+LwRXH4ojh8UbYP/3q9brk7W70QBZzpTsi/BgWKUB3JF6AQmSoidTUanUklZK5FQ7OqAP2VaFgF2aG+EA2qJiu0l6ERVWWE8io0nrps0F2ERttFJqiuQWM99S7oZ82QBZpL0Eh3XAX61h1Z2CZ8JOj7V2SA4go0zqhZoFuumI10eAbQXSNmk34BGuVMNtCNI2bi8JNAd56ZSerX0RhnMoPuPTMLqfDsoJvPzMLhJ4Pu7pmFw08G3X1mBjLhlUD398zA4ReA7u+ZgcMvAN3fM4O0RdEAPZVA9/fMIHVRNMKRaqA3HJmBwxdFJnzTzMPhiyIVvmnmIBe+aZ6TviIKO6J5hmz4prmPdPiP5joUq6GYdzVj0CyFIj7VHLN1+G/N/1AtgoKtsjp0C6BIUVaC8rUoSoY7Q/s6FCLbnaB/DQrAoDoSL0DDM6mI1NVodCaVkPx1RaMzqYDm/6l/oNGZZEY6/DdoeBYZ2Sb8LyhApmxsG/4XFCNDFsqE/wVFiZKBsuF/QYFWmo3DH4BizTYThx8ARZtlFg5/ERTviVk4/ANQyDtm4PATQDGvmIHDTwRFHTUah58MijpiNA6/ABR2xEgcfhEo7JmROPwiUNgzI3H4haC4PSMJ/Rp6bE910Jt6RuLwi0HvOjKS8HXRg4/cAfSuIyNx+MWgd/WMgjp8Ux30piMjcfjFoDcdGYnDLwa96chI6MM3lUHvOTKSlFXRo3uqgt7SMxKJ8E1F0Dt6RiITvqkGekPPSNLWRA8/Uwl0f89opMI3FUB3nxlN6pJogBGZQfeOGI1k+CYj6M4RM0hfEA1xRRbQbaNmIB/+YybonlGzoPiTQYPcNRL0/StmQhG+gYZ56grQd+6aCU34BhpnpndAP2eG2VCFb6CRdpMBuvANNNYuskAZvoFGU5cJ2vANNJ6qbFCHb6ARlWSFPvwHNCq7zMiE/4AGZlMBufAf0ODZKiEb/hsUIVJFtgj/C4oz0x3YMnwPFPLInSkX3vzF4Yvi8EVx+KI4fFEcvigOX5L3+w+v/DGd3p4PCQAAAABJRU5ErkJggg==" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 9,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "449 Oak St, Dallas", "james.garcia@gmail.com", "James Garcia", "passwordJames", "729-988-3395", "iVBORw0KGgoAAAANSUhEUgAAAH4AAAB+CAYAAADiI6WIAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAIvSURBVHhe7dFBbsJQEARR7n9pIlaJopHtTsD+rq4n9RKs+fV4qpLhSxm+lOFLGb6U4UsZvpThSxm+lOFLGb6U4UsZvpThSxm+lOFLGb6U4UsZvpThSxm+lOFLGb6U4UsZvpThSxm+VHX4x+MRjcTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFIDB+MxPDBSAwfjMTwwUgMH4zE8MFITrlmesStnWX69tZIDB+MxPDBSAwfjKQ2/PTdrdEY/uBolgz/2qdN39wajeEPjsbwB0dz2kXTY27tk6bv7Y1m2fCvfcr0ra0RGf7AiJYO/9q7Td/YG9GpV02PemTvMv333qhuEf61/5r+88ioTr9setyj+4vpf5JR3Sr8z+2ZfpOO7JLrpkdecWSXXTc99EqjM/ywBpdeOT36Cmtw+ZXTw1+5FktcOgU4e22WungKcsYaLXf1FOaTa7Xs5VOkd67dLV5gCveX6dstX2OK+nva5guVMnwpw5cyfCnDlzJ8KcNXej6/ADqIE4A0DE9uAAAAAElFTkSuQmCC" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: 10,
                columns: new[] { "Address", "Email", "Name", "Phone" },
                values: new object[] { "334 Elm St, Phoenix", "robert.williams@gmail.com", "Robert Williams", "689-560-4587" });
        }
    }
}
