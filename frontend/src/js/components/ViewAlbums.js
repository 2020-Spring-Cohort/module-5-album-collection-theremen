export default function ViewAlbums(artist) {
    return `
    <ul id="view-albums">
        ${artist.albums.map(album => {
            return `
            <li class="album">
                <div class="album__name">${album.title}</div>
                ${album.image}
                ${album.recordLabel}
                <button class="edit-album__submit">Edit</button>
                <button class="delete-album__submit">Delete</button>
                <input class="album__id" type="hidden" value="${album.albumId}">
            </li>
            `
        }).join("")}
    </ul>`
}