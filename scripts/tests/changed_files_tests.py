import unittest
from scripts.changed_files import changed_files


class TestGetChangedFiles(unittest.TestCase):

    def test_no_files(self):
        self.assertCountEqual(changed_files.get_changed_files([]), [])

    def test_no_matching_services(self):
        files = ["other-service/file.txt", "another-service/anotherfile.txt"]
        self.assertCountEqual(changed_files.get_changed_files(files), [])

    def test_some_matching_services(self):
        files = ["UserService/file1.txt", "UserService/file2.txt", "unrelated/file3.txt"]
        self.assertCountEqual(changed_files.get_changed_files(files), ["UserService"])

    def test_all_matching_services(self):
        files = ["UserService/file1.txt", "UserService/file2.txt", "UserService/file3.txt"]
        self.assertCountEqual(changed_files.get_changed_files(files), ["UserService"])

    def test_duplicate_services(self):
        files = ["UserService/file1.txt", "UserService/file2.txt"]
        self.assertCountEqual(changed_files.get_changed_files(files), ["UserService"])

if __name__ == "__main__":
    unittest.main()