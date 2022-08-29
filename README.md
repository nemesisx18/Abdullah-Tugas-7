# Abdullah-Tugas-7
Sample Game for practicing game optimization (reduce draw call, object pooling, resource load)

- Render pada main menu menggunakan sprite atlas fungsinya untuk mengurangi jumlah render jadi dapat merender kedua image menjadi satu karena sudah digabung memakai sprite atlas

- Menghapus audio source yang tidak terpakai cukup menggunakan 1 audio soruce dan load audio clip jika ingin mengganti bgm.

- Mengubah spawn mushroom menjadi object pooling untuk mengurangi beban cpu, jika object diperlukan maka cukup mengaktifkan kembali object yang telah dispawn

- Menambahkan static batching pada environment untuk mengurangi batching dengan memakai 1 mesh untuk object dengan mesh yang sama.
