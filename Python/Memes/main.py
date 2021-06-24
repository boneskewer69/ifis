import os
import time

from datetime import datetime

def get_all_files_in_directory(p_path: str) -> list:
    return [f for f in os.listdir(p_path) if os.path.isfile(os.path.join(p_path, f))]

def get_filetype(p_path: str) -> str:
    return p_path.split(".")[-1]

path = "C:\\Users\\fritz\\Desktop\\rename_memes\\rename_target_directory"
files = get_all_files_in_directory(path)

file_dict = dict()

for f in files:
    filepath = os.path.join(path, f)
    ft = get_filetype(f)
    ts = os.path.getmtime(filepath)
    s = datetime.fromtimestamp(ts)
    formatted_ts = s.strftime("%Y-%m-%d %H-%M-%S")
    file_dict[f] = f"{formatted_ts}.{ft}"

for key in file_dict.keys():
    old_filepath = os.path.join(path, key)
    new_filepath = os.path.join(path, file_dict[key])

    try:
        count = 0
        while os.path.isfile(new_filepath):
            filename = file_dict[key].split(".")[0] + f"_{count}." + file_dict[key].split(".")[1]
            count += 1
            
            new_filepath = os.path.join(path, filename)
            if not os.path.isfile(new_filepath):
                print(f"New filename already exists: '{file_dict[key]}' -> New filename: {filename}")

        os.rename(old_filepath, new_filepath)
        print(f"Renaming '{old_filepath}' to '{new_filepath}'")
    except FileExistsError:
        print(f"'{old_filepath}' cant be renamed cause '{file_dict[key]}' already exists.")
