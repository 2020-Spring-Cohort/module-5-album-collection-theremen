export default function ViewAlbums() {
    return `
    <ul id="view-albums">
        ${albums.map(album => {
            return `
            <li class="album">${album.title}
                ${album.image}
                ${album.recordLabel}
                <button class="edit-album__submit">Edit</button>
                <button class="delete-album__submit">Delete</button>
                <input class="album__id" type="hidden" value="${album.albumId}">
            </li>
            `
        }).join("")}
    </ul>

    <section class="add-album">
            <input class="add-album__albumTitle" type="text" placeholder="Add an album here">
            <input class="add-album__albumImage" type="text" placeholder="Add the album Image here">
            <input class="add-album__albumRecordLabel" type="text" placeholder="Add the album RecordLabel here">
            <button class="add-album__submit">Add an album</button>
        </section>
    `
}