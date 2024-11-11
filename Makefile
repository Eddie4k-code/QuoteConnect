.PHONY: get_changed_files python_tests

changed_files := 

get_changed_files:
	python3 ./scripts/changed_files/changed_files.py $(changed_files)

python_tests:
	python3 -m unittest discover -s ./scripts/tests -p "*.py"