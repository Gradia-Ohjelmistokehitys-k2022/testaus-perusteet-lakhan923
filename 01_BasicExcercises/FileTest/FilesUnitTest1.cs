using System.Net;
using System.Collections.Generic;
using System;
using System.IO;
using Xunit;
namespace FilesOperations;
public class FilesUnitTest1
{
    [Fact]
    public void ReadFile_ReturnsListOfSettings_IfFileIsNotEmpty()
    {
        // Arrange
        List<string> systemConfig = new List<string>();
        string winDir = "/home/isfandyarkhan/Testaus/testaus-perusteet-lakhan923/01_BasicExcercises/FileTest/";
        string filePath = "/system.ini";

        // Act
        systemConfig = Files.ReadFile(systemConfig, winDir, filePath);

        // Assert
        Assert.False(systemConfig.Count > 0);
    }

    [Fact]
    public void ReadFile_ReturnsEmptyList_IfFileIsEmpty()
    {
        // Arrange
        List<string> systemConfig = new List<string>();
        string directory = "/home/isfandyarkhan/Testaus/testaus-perusteet-lakhan923/01_BasicExcercises/FileTest/";
        string emptyFilePath = "emptyFile.txt";
        File.WriteAllText(emptyFilePath, ""); // Creating an empty file

        // Act
        systemConfig = Files.ReadFile(systemConfig, directory, emptyFilePath);

        // Assert
        Assert.Empty(systemConfig);
    }

    [Fact]
    public void ReadFile_ThrowsFileNotFoundException_IfFileDoesNotExist()
    {
        // Arrange
        List<string> systemConfig = new List<string>();
        string directory = "/home/isfandyarkhan/Testaus/testaus-perusteet-lakhan923/01_BasicExcercises/FileTest/";
        string nonExistentFilePath = "NonExistentFile.txt";

        // Act & Assert
        Assert.Throws<FileNotFoundException>(() =>
        {
            systemConfig = Files.ReadFile(systemConfig, directory, nonExistentFilePath);
        });
    }
}