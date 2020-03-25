export default function EditAlbum(albums){
    return `
    <section class="content__album">
        <h4>${album.name}</h4>
    </section>
    
    <section class="update-album">
        <input class="update-album__name" type="text" value="${album.name}">
        <input class="update-album__image" type="text" value="${album.image}">
        <input class="update-album__recordLabel" type="text" value="${album.recordLabel}">
        <input class="update-album__id" type="hidden" value="${album.albumId}">
        <button class="update-album__submit">Save Changes</button>
    </section>
`;
}