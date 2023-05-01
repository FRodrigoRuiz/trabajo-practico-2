using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuegoDeRol.Migrations
{
    /// <inheritdoc />
    public partial class AllTheRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSkill_Character_CharactersId",
                table: "CharacterSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSkill_Skill_SkillsId",
                table: "CharacterSkill");

            migrationBuilder.RenameColumn(
                name: "SkillsId",
                table: "CharacterSkill",
                newName: "SkillId");

            migrationBuilder.RenameColumn(
                name: "CharactersId",
                table: "CharacterSkill",
                newName: "CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterSkill_SkillsId",
                table: "CharacterSkill",
                newName: "IX_CharacterSkill_SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSkill_Character_CharacterId",
                table: "CharacterSkill",
                column: "CharacterId",
                principalTable: "Character",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSkill_Skill_SkillId",
                table: "CharacterSkill",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSkill_Character_CharacterId",
                table: "CharacterSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSkill_Skill_SkillId",
                table: "CharacterSkill");

            migrationBuilder.RenameColumn(
                name: "SkillId",
                table: "CharacterSkill",
                newName: "SkillsId");

            migrationBuilder.RenameColumn(
                name: "CharacterId",
                table: "CharacterSkill",
                newName: "CharactersId");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterSkill_SkillId",
                table: "CharacterSkill",
                newName: "IX_CharacterSkill_SkillsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSkill_Character_CharactersId",
                table: "CharacterSkill",
                column: "CharactersId",
                principalTable: "Character",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSkill_Skill_SkillsId",
                table: "CharacterSkill",
                column: "SkillsId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
